using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Goal
    {
        public Goal()
        {
            Day = new HashSet<Day>();
            Sprint = new HashSet<Sprint>();
            Week = new HashSet<Week>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid Milestone { get; set; }
        public string Reason { get; set; }

        public Milestone MilestoneNavigation { get; set; }
        public ICollection<Day> Day { get; set; }
        public ICollection<Sprint> Sprint { get; set; }
        public ICollection<Week> Week { get; set; }
    }
}
