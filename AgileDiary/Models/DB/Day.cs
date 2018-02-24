using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public class Day
    {
        public Day()
        {
            HabbitDayResult = new HashSet<HabbitDayResult>();
            TaskForDay = new HashSet<TaskForDay>();
        }

        public Guid Id { get; set; }
        public string Achievements { get; set; }
        public string Thanks { get; set; }
        public Guid Week { get; set; }

        public Week WeekNavigation { get; set; }
        public ICollection<HabbitDayResult> HabbitDayResult { get; set; }
        public ICollection<TaskForDay> TaskForDay { get; set; }
    }
}
