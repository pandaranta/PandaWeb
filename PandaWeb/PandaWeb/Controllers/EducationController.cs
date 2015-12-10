﻿using PandaWeb.Models;
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

        //Första gången du kör koden, så måste du instansiera upp PopulateDBWithEducationPlan
        //och du måste trycka på endast!! en av länkarna i HomeControllern för utbildnignarna, 
        //därefter stänga och köra om, men
        //med nedan rad bortkommenterad!!
        PopulateDBWithEducationPlan fillDB = new PopulateDBWithEducationPlan();
        //I mappen Global.asax.cs kommentera bort Database.SetInitializer

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
            
            var backendutveckling = from e in context.EducationPlans
                         where e.Name=="Backendutveckling"
                         select e;
            return View(backendutveckling);
        }

        public ActionResult Systemutveckling()
        {       
            var systemutveckling  = from e in context.EducationPlans
                       where e.Name=="Systemutveckling"
                       select e;
            return View(systemutveckling);
        }

        public ActionResult Course()
        {
            Course course = new Course();
            context.Course.Add(course);
            return View();
        }
    }
}