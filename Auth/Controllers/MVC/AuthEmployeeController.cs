using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Auth.Infrastructure;
using Auth.Models;
using Auth.Models.RequestModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers.MVC
{
    public class AuthEmployeeController : Controller
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly SignInManager<AspNetUser> _signInManager;
        private readonly IUserValidator<AspNetUser> _userValidator;
        private readonly IPasswordValidator<AspNetUser> _passwordValidator;
        private readonly IPasswordHasher<AspNetUser> _passwordHasher;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthEmployeeController(SignInManager<AspNetUser> signInManager,
            UserManager<AspNetUser> userManager,
            IUserValidator<AspNetUser> userValidator,
            IPasswordValidator<AspNetUser> passwordValidator,
            IPasswordHasher<AspNetUser> passwordHasher, RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult SignIn(string returnUrl)
        {
            return View(new SignInModel() {ReturnUrl = returnUrl});
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            if (!ModelState.IsValid)
            {
                return View(signInModel);
            }

            AspNetUser user = await _userManager.FindByEmailAsync(signInModel.Email);
            if (user == null)
            {
                ModelState.AddModelError("error", "Wrong email or password");
                return View(signInModel);
            }

            // var refference =
            // _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, signInModel.Password);
            
            await _signInManager.SignOutAsync();
            var signInResult =
                await _signInManager.PasswordSignInAsync(
                    user, signInModel.Password, true, false);

            if (!signInResult.Succeeded) return View(signInModel);

            return RedirectToAction("Index", "AdminUsersRoles");
            // return Redirect(signInModel.ReturnUrl);
        }

        [HttpGet]
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "AdminUsersRoles");
        }

        [HttpGet]
        public IActionResult SignUp() //todo return url
        {
            return View(new SignUpModel());
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            if (!ModelState.IsValid) return View(signUpModel);

            var user = new AspNetUser
            {
                Email = signUpModel.Email,
                UserName = signUpModel.UserName,
                PhoneNumber = signUpModel.PhoneNumber,
                RegistrationDate = DateTime.Now,
            };
            var userValidation = await _userValidator.ValidateAsync(_userManager, user);
            if (!userValidation.Succeeded)
            {
                userValidation.Errors.ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                return View(signUpModel);
            }

            var passwordValidation =
                await _passwordValidator.ValidateAsync(_userManager, user, signUpModel.Password);
            if (!passwordValidation.Succeeded)
            {
                passwordValidation.Errors.ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                return View(signUpModel);
            }

            // var passwordHash = _passwordHasher.HashPassword(user, signUpModel.Password);
            var passwordHash = signUpModel.Password;
            var signUpResult = await _userManager.CreateAsync(user, passwordHash);
            if (!signUpResult.Succeeded)
            {
                signUpResult.Errors.ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                return View(signUpModel);
            }

            user = await _userManager.FindByEmailAsync(signUpModel.Email);
            var addRoleResult = await _userManager.AddToRoleAsync(user, "user");
            var addRoleResult2 = await _userManager.AddToRoleAsync(user, "admin");
            if (!addRoleResult.Succeeded)
            {
                addRoleResult.Errors.ForEach(e => ModelState.AddModelError(e.Code, e.Description));
                return View(signUpModel);
            }

            return Redirect("https://localhost:7000/AuthPersonal/SignIn?returnUrl=google.com");
        }


        [HttpGet]
        public async Task<IActionResult> Seed()
        {
            var role1 = new IdentityRole("user");
            var role2 = new IdentityRole("admin");
            await _roleManager.CreateAsync(role1);
            await _roleManager.CreateAsync(role2);
            return Ok();
        }

        [HttpGet]
        [Authorize(Policy = "user")]
        public IActionResult IndexUser()
        {
            return View(new Dictionary<string, object>
            {
                ["User"] = HttpContext.User.Identity.Name,
                ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
                ["Auth Туре"] = HttpContext.User.Identity.AuthenticationType,
            });
        }

        [HttpGet]
        [Authorize(Policy = "admin")]
        public IActionResult IndexAdmin()
        {
            return View(new Dictionary<string, object>
            {
                ["User"] = HttpContext.User.Identity.Name,
                ["Authenticated"] = HttpContext.User.Identity.IsAuthenticated,
                ["Auth Туре"] = HttpContext.User.Identity.AuthenticationType,
            });
        }
    }
}