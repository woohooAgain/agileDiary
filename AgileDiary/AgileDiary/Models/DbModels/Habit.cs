using System;

namespace AgileDiary.Models
{
    public class Habit
    {
        public Guid HabitId { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }
    }
}
