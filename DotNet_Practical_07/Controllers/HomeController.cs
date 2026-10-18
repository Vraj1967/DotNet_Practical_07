
using System.Web.Mvc;

namespace DotNet_Practical_07.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}
