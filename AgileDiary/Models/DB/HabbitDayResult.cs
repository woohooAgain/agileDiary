using System;
using System.Collections.Generic;

namespace AgileDiary.Models.db
{
    public partial class HabbitDayResult
    {
        public Guid Habbit { get; set; }
        public Guid Day { get; set; }
        public bool? Done { get; set; }

        public Day DayNavigation { get; set; }
        public Habbit HabbitNavigation { get; set; }
    }
}
