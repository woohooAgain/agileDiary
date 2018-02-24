using System;

namespace AgileDiary.Models.DB
{
    public class HabbitDayResult
    {
        public Guid Habbit { get; set; }
        public Guid Day { get; set; }
        public bool? Done { get; set; }

        public Day DayNavigation { get; set; }
        public Habbit HabbitNavigation { get; set; }
    }
}
