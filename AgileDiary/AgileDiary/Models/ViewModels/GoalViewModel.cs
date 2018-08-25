using System;
using System.Collections.Generic;

namespace AgileDiary.Models.ViewModels
{
    public class GoalViewModel
    {
        public Guid Id { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<MilestoneViewModel> Milestones { get; set; }
        public virtual SprintViewModel Sprint { get; set; }
    }
}
