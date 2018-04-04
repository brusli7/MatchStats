using MatchStatsCore.Data;
using System.Web.Http;
using System.Web.Mvc;

namespace MatchStatsServer.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}