using PandaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PandaWeb.Controllers
{
    public class EducationController : Controller
    {
        MyDBContext context = new MyDBContext();
        // GET: Education
        public ActionResult UP()
        {
            return View();
        }

        public ActionResult LG()
        {
            //ActionResult för LG-Information
            return View();
        }

        public ActionResult Backendutveckling()
        {
            //var eduPlan = new EducationPlan();
            //eduPlan.Name = "Backendutveckling";
            //eduPlan.EducationId = 2;
            //eduPlan.StartDate =
            //    new DateTime(2015, 01, 01);
            //eduPlan.EndDate = new DateTime(2016, 12, 30);

            //context.EducationPlans.Add(eduPlan);
            //context.SaveChanges();
            var backendutveckling = from e in context.EducationPlans
                         where e.Name=="Backendutveckling"
                         select e;
            return View(backendutveckling);
        }

        public ActionResult Systemutveckling()
        {
            //var eduPlan = new EducationPlan();
            //eduPlan.Name = "Systemutveckling";
            //eduPlan.EducationId = 3;
            //eduPlan.StartDate =
            //    new DateTime(2015, 01, 01);
            //eduPlan.EndDate = new DateTime(2016, 12, 30);

            //context.EducationPlans.Add(eduPlan);
            //context.SaveChanges();
            var sys  = from e in context.EducationPlans
                       where e.Name=="Systemutveckling"
                       select e;
            return View(sys);
        }

        public ActionResult Course()
        {
            return View();
        }
    }
}