using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PandaWeb.Models
{
    public class EducationPlan
    {
        public EducationPlan(int id, string name, List<string> courses, DateTime startDate, DateTime endDate, string typeOfEducation)
        {
            ID = id;
            Name = name;
            Courses = courses;
            StartDate = startDate;
            EndDate = endDate;
            TypeOfEducation = typeOfEducation;

        }
        
        public int ID { get; set; }
        public string Name { get; set; }
        public List<String> Courses { get; set; }

        [DisplayFormat(DataFormatString="{0:yyyy/MM/dd}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime EndDate { get; set; }
        public string TypeOfEducation { get; set; }
    }
}