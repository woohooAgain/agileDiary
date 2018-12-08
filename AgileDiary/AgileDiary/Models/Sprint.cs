using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models
{
    public class Sprint
    {
        public Guid SprintId { get; set; }
        public DateTime StartDate { get; set; }
        public string Reward { get; set; }
        public List<Week> Weeks { get; set; }
        public List<Goal> Goals { get; set; }
        public SprintConclusion SprintConclusion { get; set; }
        public List<Habit> Habits { get; set; }
    }
}
