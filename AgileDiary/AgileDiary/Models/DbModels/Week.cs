using System;
using System.Collections.Generic;

namespace AgileDiary.Models
{
    public class Week
    {
        public Guid WeekId { get; set; }
        public DateTime StartDate { get; set; }
        public WeekConclusion WeekConclusion { get; set; }
        public List<TopPriority> TopPriorities { get; set; }
        public List<Task> Tasks { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }
    }
}
