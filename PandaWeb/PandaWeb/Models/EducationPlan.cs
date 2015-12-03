using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PandaWeb.Models
{
    public class EducationPlan : IEnumerable<EducationPlan>
    {
        List<EducationPlan> epList = new List<EducationPlan>();
        public int ID { get; set; }
        public string Name { get; set; }
        public List<String> Courses { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TypeOfEducation { get; set; }

        public IEnumerator<EducationPlan> GetEnumerator()
        {
            return epList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}