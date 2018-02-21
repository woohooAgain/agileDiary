using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Habbit
    {
        public Habbit()
        {
            Day = new HashSet<Day>();
            HabbitDayResult = new HashSet<HabbitDayResult>();
            Sprint = new HashSet<Sprint>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }

        public ICollection<Day> Day { get; set; }
        public ICollection<HabbitDayResult> HabbitDayResult { get; set; }
        public ICollection<Sprint> Sprint { get; set; }
    }
}
