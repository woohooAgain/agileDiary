using System;
using System.Collections.Generic;

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
        public string Creator { get; set; }
    }
}
