using System;
using System.Collections.Generic;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Week
    {
        public Week()
        {
        }

        public Week(Guid sprintId, DateTime startOfWeek)
        {
            Start = startOfWeek;
            End = Start + TimeSpan.FromDays(6);
            SprintId = sprintId;
        }

        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public ICollection<Day> Days { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}