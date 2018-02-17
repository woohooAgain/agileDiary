using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class SprintGoal : Goal
    {
        public List<string> Milestones { get; set; }

        public string Reason { get; set; }
    }
}
