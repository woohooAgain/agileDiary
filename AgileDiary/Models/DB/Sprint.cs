using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Sprint
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public Guid Goal { get; set; }
        public Guid Habbit { get; set; }
        public Guid Result { get; set; }
        public Guid Week { get; set; }
        public string Reward { get; set; }

        public Goal GoalNavigation { get; set; }
        public Habbit HabbitNavigation { get; set; }
        public Result ResultNavigation { get; set; }
        public Week WeekNavigation { get; set; }
    }
}
