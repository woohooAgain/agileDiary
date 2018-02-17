using System;

namespace AgileDiary.Models.AgileDiary.DbModel
{
    public class Goal
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Milestone { get; set; }

        public string Reason { get; set; }
    }
}
