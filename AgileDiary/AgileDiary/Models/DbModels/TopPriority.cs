using System;

namespace AgileDiary.Models
{
    public class TopPriority
    {
        public Guid TopPriorityId { get; set; }
        public string Description { get; set; }

        public Guid WeekId { get; set; }
        public Week Week { get; set; }
    }
}
