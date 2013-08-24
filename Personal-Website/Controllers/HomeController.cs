using System.Web.Mvc;

namespace Personal_Website.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
    }
}