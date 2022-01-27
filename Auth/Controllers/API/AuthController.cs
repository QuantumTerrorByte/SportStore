using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using Auth.Infrastructure;
using Auth.Models;
using Auth.Models.RequestModel;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Auth.Controllers.API
{
    // [EnableCors]
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly SignInManager<AspNetUser> _signInManager;
        private readonly IPasswordValidator<AspNetUser> _passwordValidator;
        private readonly IPasswordHasher<AspNetUser> _passwordHasher;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(UserManager<AspNetUser> userManager, SignInManager<AspNetUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IPasswordValidator<AspNetUser> passwordValidator, IPasswordHasher<AspNetUser> passwordHasher)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "user")]
        [Route("Info")]
        public IActionResult Info()
        {
            return Ok(
                new Dictionary<string, object>
                {
                    ["User"] = HttpContext.User.Identity.Name,
                    ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
                    ["Auth Туре"] = HttpContext.User.Identity.AuthenticationType,
                });
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "user")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _userManager.Users.ToArrayAsync());
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "admin")]
        [Route("Index2")]
        public async Task<IActionResult> Index2()
        {
            return Ok(await _userManager.Users.ToArrayAsync());
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "god")]
        [Route("Index3")]
        public async Task<IActionResult> Index3()
        {
            return Ok(await _userManager.Users.ToArrayAsync());
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> SignInCostumers([FromBody] SignInModel signInModel)
        {
            AspNetUser user = await _userManager.FindByEmailAsync(signInModel.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, signInModel.Password))
            {
                return BadRequest("Wrong email or password");
            }

            var roles = _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim("id", user.Id),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            };

            foreach (var role in await roles)
            {
                claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role));
            }

            var now = DateTime.Now;
            var jwt = new JwtSecurityToken(
                issuer: JwtOptions.ISSUER,
                audience: JwtOptions.AUDIENCE,
                claims: claims,
                notBefore: now,
                expires: now.Add(TimeSpan.FromHours(JwtOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(JwtOptions.GetKey(), SecurityAlgorithms.HmacSha256)
            );
            var result = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(new
            {
                access_token = result,
                userInfo = new
                {
                    Email = user.Email,
                    Id = user.Id,
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber
                }
            });
        }

        /// <summary>
        /// add user into db, and set user role
        /// </summary>
        /// <param name="signUpModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SignUp")]
        public async Task<ActionResult> SignUp([FromBody] SignUpModel signUpModel)
        {
            var newUser = new AspNetUser
            {
                Email = signUpModel.Email,
                PhoneNumber = signUpModel.PhoneNumber,
                UserName = signUpModel.UserName
            };
            var isCreatingValid =
                await _userManager.CreateAsync(newUser, signUpModel.Password); //todo pass hash
            if (!isCreatingValid.Succeeded) return BadRequest(isCreatingValid.Errors);

            var isInRole = await _userManager.AddToRoleAsync(newUser, "user");
            if (!isInRole.Succeeded) return BadRequest(isInRole.Errors);

            return Ok(newUser);
        }

        [HttpPost]
        [Route("Edit")]
        [Authorize]
        public async Task<ActionResult> Edit(UserViewModel authModel)
        {
            var user = await _userManager.FindByIdAsync(authModel.Id);
            if (user == null) return NotFound("Wrong user id");

            IdentityResult passwordValid =
                await _passwordValidator.ValidateAsync(_userManager, user, authModel.Password);
            if (!passwordValid.Succeeded) return BadRequest(passwordValid.Errors);

            user.Email = authModel.Email;
            user.UserName = authModel.UserName;
            user.PhoneNumber = authModel.PhoneNumber;
            user.PasswordHash = _passwordHasher.HashPassword(user, authModel.Password);

            IdentityResult validUser = await _userManager.UpdateAsync(user);
            if (!validUser.Succeeded) return BadRequest(validUser.Errors);

            return Ok(user);
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<ActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound("cant find user with this email");

            var isDeleted = await _userManager.DeleteAsync(user);
            if (!isDeleted.Succeeded) return BadRequest(isDeleted.Errors);

            return Ok(user);
        }

        [HttpGet]
        [Route("Seed")]
        public async Task<IActionResult> Seed()
        {
            var roles = new[] {"user", "admin", "operator"};
            foreach (var role in roles)
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }

            return Ok();
        }
    }
}