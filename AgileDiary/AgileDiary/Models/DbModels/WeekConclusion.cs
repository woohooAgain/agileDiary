using System;

namespace AgileDiary.Models
{
    public class WeekConclusion
    {
        public Guid WeekConclusionId { get; set; }
        public string Achievment { get; set; }
        public string Thanks { get; set; }
        public string Lesson { get; set; }
        public string Improvement { get; set; }

        public Guid WeekId { get; set; }
        public Week Week { get; set; }
    }
}
