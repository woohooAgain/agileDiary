using System;

namespace AgileDiary.Models.AgileDiary.DbModel
{
    public class Task
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Guid Id { get; set; }

        public string Title { get; set; }
    }
}
