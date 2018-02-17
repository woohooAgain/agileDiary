using System;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class Task
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}
