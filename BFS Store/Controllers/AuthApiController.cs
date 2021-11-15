using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SportStore.Models.RequestModel;

namespace SportStore.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IPasswordValidator<AppUser> _passwordValidator;
        private readonly IPasswordHasher<AppUser> _passwordHasher;

        public AuthApiController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            IPasswordValidator<AppUser> passwordValidator, IPasswordHasher<AppUser> passwordHasher)
        {
            _userManager = userManager;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("Info")]
        public async Task<IActionResult> UserInfo(string userId)
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
        [Route("Index")]
        public async Task<IActionResult> UsersInfo()
        {
            return Ok(await _userManager.Users.ToArrayAsync());
        }

        [HttpPost]
        [Route("SignIn")]
        public async Task<ActionResult> SignIn([FromBody] UserAuthModel userAuthModel = null)
        {
            Console.WriteLine($"in SignIn {userAuthModel}");
            var user = await _userManager.FindByEmailAsync(userAuthModel.Email);
            if (user == null) return BadRequest("Wrong email or password");

            await _signInManager.SignOutAsync();
            var result = await _signInManager.PasswordSignInAsync(user, userAuthModel.Password,
                userAuthModel.RememberMe, false);
            Console.WriteLine(user.AccessFailedCount);
            if (result.Succeeded)
            {
                return Ok(new UserAuthCrudModel
                {
                    Email = user.Email,
                    Id = user.Id,
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber
                });
            }

            if (result.IsLockedOut) return BadRequest("User is locked out");

            return result.IsNotAllowed
                ? BadRequest("User not allowed")
                : BadRequest("Wrong email or password");
        }

        [HttpPost]
        [Route("SignOut")]
        [Authorize]
        public async Task<ActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<ActionResult> SignUp([FromBody] UserAuthCrudModel userAuthModel)
        {
            var newUser = new AppUser
            {
                Email = userAuthModel.Email,
                PhoneNumber = userAuthModel.PhoneNumber,
                UserName = userAuthModel.UserName
            };
            IdentityResult isCreatingValid = await _userManager.CreateAsync(newUser, userAuthModel.Password);
            if (isCreatingValid.Succeeded)
            {
                newUser.PasswordHash = userAuthModel.Password;
                return Ok(newUser);
            }

            return BadRequest(isCreatingValid.Errors);
        }

        [HttpPost]
        [Route("Edit")]
        [Authorize]
        public async Task<ActionResult> Edit(UserAuthCrudModel userAuthModel)
        {
            var user = await _userManager.FindByIdAsync(userAuthModel.Id);
            if (user == null) return NotFound("Wrong user id");

            IdentityResult passwordValid =
                await _passwordValidator.ValidateAsync(_userManager, user, userAuthModel.Password);
            if (!passwordValid.Succeeded) return BadRequest(passwordValid.Errors);

            user.Email = userAuthModel.Email;
            user.UserName = userAuthModel.UserName;
            user.PhoneNumber = userAuthModel.PhoneNumber;
            user.PasswordHash = _passwordHasher.HashPassword(user, userAuthModel.Password);

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
    }
}