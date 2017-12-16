
using i04.Web.Models.Home;
using System.Web.Mvc;

namespace i04.Web.Controllers
{
    public class HomeController : Controller
    {
    

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}