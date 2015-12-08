using PandaWeb.Models;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page with text.";

            return View();
        }

        public ActionResult EducationPlan()
        {
            ViewBag.Message = "Utbildningsplan";
            var id = 1;
            var name = "Systemutveckling";
            var courses = new List<string> { "kurs 1", "kurs 2", "kurs 3" };
            var startDate = new DateTime(2014, 08, 01);
            var endDate = new DateTime(2016, 10, 30);
            var type = "På plats";
            EducationPlan eduPlan = new EducationPlan(id, name, courses, startDate, endDate, type);
            return View(eduPlan);
        }
    }
}