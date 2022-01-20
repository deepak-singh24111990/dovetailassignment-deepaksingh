using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoveTailQ1.Controllers
{
    public class RegisterController : Controller
    {
        // GET: RegisterController
        public ActionResult Index()
        {
            return View();
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
             if (ModelState.IsValid)
                {
                    //Data will be added here in DB or API will be called.
                    ViewBag.message = "Your account has been created";
                }
                return View("Index");
            
        }

       
    }
}
