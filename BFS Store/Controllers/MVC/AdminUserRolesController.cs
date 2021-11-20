using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportStore.Infrastructure;
using SportStore.Models;
using SportStore.Models.Auth;
using SportStore.Models.ViewModels;

namespace SportStore.Controllers.MVC
{
    public class AdminUsersRolesController : Controller
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly IUserValidator<AspNetUser> _userValidator;
        private readonly IPasswordValidator<AspNetUser> _passwordValidator;
        private readonly IPasswordHasher<AspNetUser> _passwordHasher;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminUsersRolesController(UserManager<AspNetUser> userManager, IUserValidator<AspNetUser> userValidator,
            IPasswordValidator<AspNetUser> passwordValidator, IPasswordHasher<AspNetUser> passwordHasher,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
            _roleManager = roleManager;
        }

        public async Task<ActionResult> Index()
        {
            ViewBag.Manager = _userManager;
            return View(await _userManager.Users.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult> Edit(string userEmail)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            var userRoles = await _userManager.GetRolesAsync(user);
            var allRoles = await _roleManager.Roles.Select(identity => identity.Name).ToArrayAsync();

            var model = new UserEditRolesViewModel
            {
                UserName = user.UserName,
                UserEmail = user.Email,
                UserRoles = userRoles.ToArray(),
                AllRoles = allRoles,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(string userEmail, string[] newUserRoles)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user == null) return NotFound("Wrong mail");

            var exUserRoles = await _userManager.GetRolesAsync(user);
            var add = newUserRoles.Except(exUserRoles);
            var remove = exUserRoles.Except(newUserRoles);
            var addResult = await _userManager.AddToRolesAsync(user, add);
            var removeResult = await _userManager.RemoveFromRolesAsync(user, remove);
            if (!addResult.Succeeded)
            {
                addResult.Errors.ForEach(x => ModelState.AddModelError(x.Code, x.Description));
            }

            if (!removeResult.Succeeded)
            {
                removeResult.Errors.ForEach(x => ModelState.AddModelError(x.Code, x.Description));
            }

            if (!ModelState.IsValid)
            {
                return await Edit(userEmail);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}