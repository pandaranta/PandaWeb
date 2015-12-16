using PandaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using PandaWeb.ViewModels;

namespace PandaWeb.Controllers
{
    public class EducationController : Controller
    {
        MyDBContext context = new MyDBContext();

        //Första gången du kör koden, så måste du instansiera upp PopulateDBWithEducationPlan
        //och du måste trycka på endast!! en av länkarna i HomeControllern för utbildnignarna, 
        //därefter stänga och köra om, men
        //med nedan rad bortkommenterad!!
        //PopulateDBWithEducationPlan fillDB = new PopulateDBWithEducationPlan();
        //I mappen Global.asax.cs kommentera bort Database.SetInitializer

        // GET: UP
        public ActionResult UPSystemutveckling()
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

            var output = (from e in context.EducationPlans
                          where e.Name == "Backendutveckling"
                          select e);
            return View(output);
        }

        public ActionResult Systemutveckling()
        {       
            var systemutveckling  = from e in context.EducationPlans
                       where e.Name=="Systemutveckling"
                       select e;
            return View(systemutveckling);
        }

        //visar alla kurser som tillhör Backendutveckling i listformat
         public ActionResult Course()
        {
            var cour = context.Course.Where(c => c.EducationPlanId == 2).Select(c=>c);   
            return View(cour);
        }
    }
}