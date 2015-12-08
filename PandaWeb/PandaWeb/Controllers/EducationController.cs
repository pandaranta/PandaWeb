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
            //så småningom hämtas från en databas
            ViewBag.Message = "Utbildningsplan";
            return View();
        }

        public ActionResult Course()
        {
            return View();
        }
    }
}