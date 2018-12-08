using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.ViewModels
{
    public class GoalViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<MilestoneViewModel> Milestones { get; set; }
        public string Result { get; set; }

        public Guid SprintId { get; set; }
    }
}
