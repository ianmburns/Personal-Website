using System.Web.Mvc;

namespace Personal_Website.Controllers
{
    public class ResumeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Experience()
        {
            return PartialView();
        }

        public ActionResult TechnicalSkills()
        {
            return PartialView();
        }

        public ActionResult Education()
        {
            return PartialView();
        }
    }
}
