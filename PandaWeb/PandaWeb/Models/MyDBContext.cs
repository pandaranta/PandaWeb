using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PandaWeb.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<EducationPlan> EducationPlans { get; set; }

    }
}