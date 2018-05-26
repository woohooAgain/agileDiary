using System;
using System.Collections.Generic;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Habit
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int MaxChainLength { get; set; }
        public int Total { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public ICollection<DailyHabitResult> HabitResults { get; set; }
    }
}