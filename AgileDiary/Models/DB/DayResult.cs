using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class DayResult
    {
        public DayResult()
        {
            Day = new HashSet<Day>();
        }

        public Guid Id { get; set; }
        public decimal ExerciseTime { get; set; }
        public short Mood { get; set; }
        public decimal SleepTime { get; set; }
        public short WaterGlases { get; set; }
        public Guid HabbitResult { get; set; }

        public HabbitDayResult HabbitResultNavigation { get; set; }
        public ICollection<Day> Day { get; set; }
    }
}
