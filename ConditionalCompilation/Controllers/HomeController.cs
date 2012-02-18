using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConditionalCompilation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
#if DEBUG
            ViewBag.Message = "DEBUG MODE";
#else
            ViewBag.Message = "RELEASE MODE";
#endif

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
