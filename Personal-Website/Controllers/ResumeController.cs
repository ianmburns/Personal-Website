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
            return PartialView("_Experience");
        }

        public ActionResult TechnicalSkills()
        {
            return PartialView("_TechnicalSkills");
        }

        public ActionResult Education()
        {
            return PartialView("_Education");
        }
    }
}