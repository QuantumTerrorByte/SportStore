using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers.MVC
{
    public class AdminUsersRolesMvcController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserValidator<AppUser> _userValidator;
        private readonly IPasswordValidator<AppUser> _passwordValidator;
        private readonly IPasswordHasher<AppUser> _passwordHasher;

        public AdminUsersRolesMvcController(UserManager<AppUser> userManager, IUserValidator<AppUser> userValidator,
            IPasswordValidator<AppUser> passwordValidator, IPasswordHasher<AppUser> passwordHasher)
        {
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
        }

        // GET: AdminMemberRolesMvc
        public ActionResult ControlPanel()
        {
            return View(_userManager.Users);
        }

        // GET: AdminMemberRolesMvc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminMemberRolesMvc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminMemberRolesMvc/Create
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(ControlPanel));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        // [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(ControlPanel));
            }
            catch
            {
                return View();
            }
        }
        
        
    }
}