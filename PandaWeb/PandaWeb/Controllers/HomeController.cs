using AutoMapper;
using PandaWeb.Models;
using PandaWeb.ViewModels;
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
        //originalkod
        //public ActionResult Index()
        //{
        //    MyDBContext context = new MyDBContext();
        //    var all = (from e in context.EducationPlans select e);
        //    return View(all);
        //}

        public ActionResult Edu()
        {
            MyDBContext context = new MyDBContext();
            var all = (from e in context.EducationPlans select e);
            return View(Mapper.Map<ICollection<IndexVM>>(all));
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
    }
}