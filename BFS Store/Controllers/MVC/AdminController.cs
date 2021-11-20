using Microsoft.AspNetCore.Mvc;

namespace SportStore.Controllers.MVC
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult ControlPanel()
        {
            return View();
        }

    }
}