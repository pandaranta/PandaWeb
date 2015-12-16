using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PandaWeb.Models
{
    public class EduCourseViewModel
    {
        public int EduCourseViewModelID { get; set; }
        public string Name { get; set; }

        public EduCourseViewModel()
        {

        }
        //MyDBContext context = new MyDBContext();
        //public EducationPlan GetEdu()
        //{
        //    var edu = context.EducationPlans.First();

        //    return edu;
        //}
    }
}