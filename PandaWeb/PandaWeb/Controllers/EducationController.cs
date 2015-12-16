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
using AutoMapper;

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
        IRepository repository = new MyDBContextRepository();

        public ActionResult Details(int id)
        {    
            return View(repository.GetEduPlansDetailsViewModel(id));
        }

        public ActionResult CourseDetails(int id)
        {
            return View(repository.GetCoursesDetailsViewModel(id));
        }

        public ActionResult EduCourse()
        {
            return View();
        }
    }
}