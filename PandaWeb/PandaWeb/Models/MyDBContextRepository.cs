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

        ICollection<IndexVM> IRepository.GetCoursesDetailsViewModel(int id)
        {
            using (var db = new MyDBContext())
            {
                var vm = db.Course.Where(cp=>cp.EducationPlanId== id).Select(cp=>cp);
                var mm = Mapper.Map<ICollection<IndexVM>>(vm);
                return mm;
            }
        }


        //IndexVM IRepository.GetCoursesDetailsViewModel(int id)
        //{
        //    using (var db = new MyDBContext())
        //    {
        //        var vm = db.Course.SingleOrDefault(cp => cp.EducationPlanId == id);
        //        var mm = Mapper.Map<IndexVM>(vm);
        //        return mm;
        //    }
        //}
    }
}