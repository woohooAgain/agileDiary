using System;

namespace AgileDiary.Models.DB
{
    public class Milestone
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int EstimationWeek { get; set; }
        public Guid Goal { get; set; }

        public Goal GoalNavigation { get; set; }
    }
}
