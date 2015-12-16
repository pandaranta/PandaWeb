using PandaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PandaWeb.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual EducationPlan EducationPlan { get; set; }
    }
}