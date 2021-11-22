using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers.MVC
{
    public class AdminController : Controller
    {
        // GET: Admin
        [Authorize (Policy = "admin")]
        public ActionResult ControlPanel()
        {
            return View();
        }

    }
}