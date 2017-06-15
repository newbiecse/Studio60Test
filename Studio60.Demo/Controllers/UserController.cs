using Studio60.Demo.CustomBinders;
using Studio60.Demo.ViewModels;
using System;
using System.Web.Mvc;

namespace Studio60.Demo.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new UserViewModel { DateOfBirth = DateTime.Now.AddDays(-1) });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([ModelBinder(typeof(UserBinder))] UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["User"] = string.Format("The user with {0} email was created successful!", model.Email);

                return RedirectToAction("Index");
            }

            return View("Index", model);
        }
    }
}