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

        public ActionResult EducationPlan()
        {
            var eduPlan = new EducationPlan();
            eduPlan.Name = "Backendutveckling";
            eduPlan.EducationId = 2;
            eduPlan.StartDate =
                new DateTime(2015, 01, 01);
            eduPlan.EndDate = new DateTime(2016, 12, 30);

            context.EducationPlans.Add(eduPlan);
            context.SaveChanges();
            context.Database.Connection.Close();

            context.Database.Connection.Open();
            var trying = from e in context.EducationPlans
                         orderby e.Name
                         select e;
            context.Database.Connection.Close();
            return View(trying);
        }

        public ActionResult Course()
        {
            return View();
        }
    }
}