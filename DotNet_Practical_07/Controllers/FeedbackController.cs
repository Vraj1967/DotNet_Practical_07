
using System;
using System.Web.Mvc;
using DotNet_Practical_07.Models;

namespace DotNet_Practical_07.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Feedback
            {
                Date = DateTime.Today
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Submitted = true;
                return View(model);
            }

            return View(model);
        }
    }
}
