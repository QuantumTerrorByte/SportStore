using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using SportStore.Models.RequestModel;

namespace SportStore.Controllers.MVC
{
    public class AuthPersonalController : Controller
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly SignInManager<AspNetUser> _signInManager;

        public AuthPersonalController(SignInManager<AspNetUser> signInManager, UserManager<AspNetUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            if (ModelState.IsValid)
            {
                AspNetUser user = await _userManager.FindByEmailAsync(signInModel.Email);
                if (user != null)
                {
                    var signInResult = await _signInManager.PasswordSignInAsync(user, signInModel.Password, true, false);
                    await _signInManager.SignInAsync(user, true);
                    if (signInResult.Succeeded)
                    {
                        return RedirectToAction("Index", "AdminUsersRoles");
                    }
                }

                return BadRequest("Wrong email or password");
            }

            return View(signInModel);
        }

        [HttpGet]
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "AdminUsersRoles");
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