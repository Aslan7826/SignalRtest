using System.Web.Mvc;

namespace SignalRtest.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string message)
        {
            return View();
        }
    }
}