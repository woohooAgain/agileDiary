using System;

namespace AgileDiary.Models.AgileDiary.DbModel
{
    public class GoalResult
    {
        public Guid Id { get; set; }

        public Guid Goal { get; set; }

        public string Result { get; set; }
    }
}
