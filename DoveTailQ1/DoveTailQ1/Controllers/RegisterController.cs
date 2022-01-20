namespace DoveTailQ1.Controllers
{
    using DoveTailQ1.Models;
    using Microsoft.AspNetCore.Mvc;
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                TempData["message"] = "Your account has been created";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
