using System;

namespace AltAgileDiary.Models.AgileDiary
{
    public class DailyHabitResult
    {
        public Guid Id { get; set; }
        public bool? Done { get; set; }

        public Guid HabitId { get; set; }
        public Habit Habit { get; set; }

        public Guid DayId { get; set; }
        public Day Day { get; set; }
    }
}
