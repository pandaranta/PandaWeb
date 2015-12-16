using AutoMapper;
using PandaWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PandaWeb.Models;

namespace PandaWeb.Models
{
    public class MyDBContextRepository : IRepository
    {
       
       ICollection<IndexVM> IRepository.GetIndexViewModel()
        {
            using (var db = new MyDBContext())
            {
                var em = db.EducationPlans;
                var vm = Mapper.Map<ICollection<IndexVM>>(em);
                return vm;
            }
        }

        EduPlanDetailsVM IRepository.GetEduPlansDetailsViewModel(int id)
        {
            using (var db = new MyDBContext())
            {
                var em = db.EducationPlans.SingleOrDefault(ep=>ep.EducationId==id);
                em.Courses = db.Course.Where(c => c.EducationPlanId == em.EducationId).ToArray();
                var vm = Mapper.Map<EduPlanDetailsVM>(em);
                return vm;
            }
        }
    }
}