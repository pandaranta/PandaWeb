using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PandaWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "TEAM PANDAS PAGE";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt Erik";

            return View();
        }
    }
}