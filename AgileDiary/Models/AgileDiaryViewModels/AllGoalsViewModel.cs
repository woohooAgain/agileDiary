using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Models.Db;

namespace AgileDiary.Models.AgileDiaryViewModels
{
    public class AllGoalsViewModel
    {
        public IEnumerable<Guid> Goals { get; set; }
    }
}
