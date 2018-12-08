using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models
{
    public class Milestone
    {
        public Guid MilestoneId { get; set; }
        public string Description { get; set; }

        public Guid GoalId { get; set; }
        public Goal Goal { get; set; }
    }
}
