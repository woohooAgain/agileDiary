using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public class Week
    {
        public Week()
        {
            Day = new HashSet<Day>();
            SprintNavigation = new HashSet<Sprint>();
            TaskForWeek = new HashSet<TaskForWeek>();
        }

        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }
        public Guid Sprint { get; set; }

        public Sprint Sprint1 { get; set; }
        public ICollection<Day> Day { get; set; }
        public ICollection<Sprint> SprintNavigation { get; set; }
        public ICollection<TaskForWeek> TaskForWeek { get; set; }
    }
}
