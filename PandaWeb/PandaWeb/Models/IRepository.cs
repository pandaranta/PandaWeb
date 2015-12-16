using PandaWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaWeb.Models
{
    interface IRepository
    {
         ICollection<IndexVM> GetIndexViewModel();
         EduPlanDetailsVM GetEduPlansDetailsViewModel(int id);
    }
}
