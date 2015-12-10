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

        //Första gången du kör koden, så måste du instansiera upp PopulateDBWithEducationPlan
        //och du måste trycka på endast!! en av länkarna i HomeControllern för utbildnignarna, 
        //därefter stänga och köra om, men
        //med nedan rad bortkommenterad!!
        //PopulateDBWithEducationPlan fillDB = new PopulateDBWithEducationPlan();

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
            return View();
        }

        public ActionResult DropDownList()
        {
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "Jemma", Value = "0" });
            li.Add(new SelectListItem { Text = "Peter", Value = "1" });
            li.Add(new SelectListItem { Text = "Joel", Value = "2" });
            ViewData["Name"] = li;
            return View(li);
        }
    }
}