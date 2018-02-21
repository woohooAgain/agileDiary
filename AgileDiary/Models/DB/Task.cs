using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Task
    {
        public Task()
        {
            Day = new HashSet<Day>();
        }

        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Title { get; set; }

        public ICollection<Day> Day { get; set; }
    }
}
