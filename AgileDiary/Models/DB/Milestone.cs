using System;
using System.Collections.Generic;

namespace AgileDiary.Models.db
{
    public partial class Milestone
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int? EstimationWeek { get; set; }
        public Guid Goal { get; set; }

        public Goal GoalNavigation { get; set; }
    }
}
