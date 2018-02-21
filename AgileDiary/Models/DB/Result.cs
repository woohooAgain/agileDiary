using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Result
    {
        public Result()
        {
            Sprint = new HashSet<Sprint>();
            Week = new HashSet<Week>();
        }

        public Guid Id { get; set; }
        public Guid GoalResult { get; set; }
        public Guid ResultDescription { get; set; }

        public GoalResult GoalResultNavigation { get; set; }
        public ResultDescription ResultDescriptionNavigation { get; set; }
        public ICollection<Sprint> Sprint { get; set; }
        public ICollection<Week> Week { get; set; }
    }
}
