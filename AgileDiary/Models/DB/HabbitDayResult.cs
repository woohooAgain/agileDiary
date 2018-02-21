using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class HabbitDayResult
    {
        public HabbitDayResult()
        {
            DayResult = new HashSet<DayResult>();
        }

        public Guid Id { get; set; }
        public Guid Habbit { get; set; }
        public bool Result { get; set; }

        public Habbit HabbitNavigation { get; set; }
        public ICollection<DayResult> DayResult { get; set; }
    }
}
