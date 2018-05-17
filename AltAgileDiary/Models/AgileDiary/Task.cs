using System;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Finished { get; set; }

        public Guid? GoalId { get; set; }
        public Goal Goal { get; set; }

        public Guid DayId { get; set; }
        public Day Day { get; set; }

        public Guid WeekId { get; set; }
        public Week Week { get; set; }
    }
}
