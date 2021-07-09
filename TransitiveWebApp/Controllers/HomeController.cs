using BusinessLogic;
using System.Web.Mvc;

namespace TransitiveWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var decisionMaker = new DecisionMaker();
            decisionMaker.PickANumber();

            return View();
        }
    }
}
