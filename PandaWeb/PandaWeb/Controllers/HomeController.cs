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
            EducationPlan eduPlan = new EducationPlan();
            eduPlan.ID = 1;
            eduPlan.Name = "Systemutveckling";
            eduPlan.StartDate = new DateTime(2014, 08, 01);
            eduPlan.EndDate = new DateTime(2016, 10, 30);
            eduPlan.Courses = new List<string> { "Kurs 1", "Kurs 2", "Kurs 3" };
            eduPlan.TypeOfEducation = "På plats";
            return View(eduPlan);
        }
    }
}