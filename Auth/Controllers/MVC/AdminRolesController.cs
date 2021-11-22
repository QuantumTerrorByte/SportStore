using System.Threading.Tasks;
using Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Auth.Controllers.MVC
{
    public class AdminRolesController : Controller
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly IUserValidator<AspNetUser> _userValidator;
        private readonly IPasswordValidator<AspNetUser> _passwordValidator;
        private readonly IPasswordHasher<AspNetUser> _passwordHasher;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminRolesController(UserManager<AspNetUser> userManager, IUserValidator<AspNetUser> userValidator,
            IPasswordValidator<AspNetUser> passwordValidator, IPasswordHasher<AspNetUser> passwordHasher,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
            _roleManager = roleManager;
        }

        // GET
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _roleManager.Roles.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(string roleName)
        {
            var role = new IdentityRole(roleName);
            var createResult = await _roleManager.CreateAsync(role);
            if (createResult.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            var delResult = await _roleManager.DeleteAsync(role);
            if (delResult.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction();
        }
    }
}