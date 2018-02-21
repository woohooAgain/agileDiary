using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Day
    {
        public Day()
        {
            Week = new HashSet<Week>();
        }

        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid Goal { get; set; }
        public Guid Habbit { get; set; }
        public Guid Result { get; set; }
        public Guid Task { get; set; }

        public Goal GoalNavigation { get; set; }
        public Habbit HabbitNavigation { get; set; }
        public DayResult ResultNavigation { get; set; }
        public Task TaskNavigation { get; set; }
        public ICollection<Week> Week { get; set; }
    }
}
