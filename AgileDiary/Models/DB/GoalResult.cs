using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class GoalResult
    {
        public GoalResult()
        {
            ResultNavigation = new HashSet<Result>();
        }

        public Guid Id { get; set; }
        public Guid Goal { get; set; }
        public string Result { get; set; }

        public ICollection<Result> ResultNavigation { get; set; }
    }
}
