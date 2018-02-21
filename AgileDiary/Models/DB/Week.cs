using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Week
    {
        public Week()
        {
            Sprint = new HashSet<Sprint>();
        }

        public Guid Id { get; set; }
        public Guid Day { get; set; }
        public Guid Goal { get; set; }
        public Guid Result { get; set; }

        public Day DayNavigation { get; set; }
        public Goal GoalNavigation { get; set; }
        public Result ResultNavigation { get; set; }
        public ICollection<Sprint> Sprint { get; set; }
    }
}
