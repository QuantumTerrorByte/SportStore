using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers
{
    public class AdminMemberRolesMvcController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserValidator<AppUser> _userValidator;
        private readonly IPasswordValidator<AppUser> _passwordValidator;
        private readonly IPasswordHasher<AppUser> _passwordHasher;

        public AdminMemberRolesMvcController(UserManager<AppUser> userManager, IUserValidator<AppUser> userValidator,
            IPasswordValidator<AppUser> passwordValidator, IPasswordHasher<AppUser> passwordHasher)
        {
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
        }

        // GET: AdminMemberRolesMvc
        public ActionResult Index()
        {
            return View();
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

                return RedirectToAction(nameof(Index));
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

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        
    }
}