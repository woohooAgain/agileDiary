using System;
using System.Collections.Generic;

namespace AgileDiary.Models.Db
{
    public partial class Habbit
    {
        public Habbit()
        {
            HabbitDayResult = new HashSet<HabbitDayResult>();
        }

        public Guid Id { get; set; }
        public int Chain { get; set; }
        public int Total { get; set; }
        public Guid Sprint { get; set; }

        public Sprint SprintNavigation { get; set; }
        public ICollection<HabbitDayResult> HabbitDayResult { get; set; }
    }
}
