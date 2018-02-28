using System;
using System.Collections.Generic;

namespace AgileDiary.Models.Db
{
    public partial class Week
    {
        public Week()
        {
            Day = new HashSet<Day>();
            TaskForWeek = new HashSet<TaskForWeek>();
        }

        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }
        public Guid Sprint { get; set; }

        public Sprint SprintNavigation { get; set; }
        public ICollection<Day> Day { get; set; }
        public ICollection<TaskForWeek> TaskForWeek { get; set; }
    }
}
