using PandaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

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

        public ActionResult UploadDocuments()
        {
            return View();
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

        //Den här metoden är inte klar, eftersom den aldrig sparar något i databasen
        public ActionResult Save(FormCollection formCollection)
        {
            if(Request!=null)
            {
                HttpPostedFileBase file = Request.Files["Uploaded File"];
                if((file!=null) && (file.ContentLength>0) && !string.IsNullOrEmpty(file.FileName))
                {
                    //string fileName = file.FileName;
                    //string fileContentType = file.ContentType;
                    byte[] fileBytes = new byte[file.ContentLength];
                    file.InputStream.Read(fileBytes, 0, Convert.ToInt32(file.ContentLength));

                    //string fileNames = Path.GetFileName(Request.Files["file"].FileName);
                    Documents doc = new Documents();
                    doc.Document = fileBytes;
                    doc.DocType = file.ContentType;

                    doc.FileName = file.FileName;
                    context.Documents.Add(doc);
                    context.SaveChanges();
                   
                    //http://scottlilly.com/how-to-upload-a-file-in-an-asp-net-mvc-4-page/

                }
            }
            return RedirectToAction("Backendutveckling");
        }

        public ActionResult ShowDocuments()
        {
            //ska anpassas för att endast visa dokument för den som är inloggad
            var doc = (from e in context.Documents
                       select e);
            return View(doc);
        }

        public ActionResult DownloadFile(int id)
        {
            var doc = (from e in context.Documents where e.Id==id select e.Document);
            //var docu = (context.Documents.Where(p => p.Id == id).Select(p => p));
            var docu = context.Documents.Single(p => p.Id == id);
            //var docu2 = context.Documents.Where(p => p.Id == id).Select(p => p.DocType).ToString();
            return File(docu.Document, docu.DocType);
        }
    }
}