using System;

namespace AgileDiary.Models
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid GoalId { get; set; }

        public Guid WeekId { get; set; }
        public Week Week { get; set; }        
    }
}