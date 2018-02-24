using System;

namespace AgileDiary.Models.DB
{
    public class TaskForDay
    {
        public Guid Task { get; set; }
        public Guid Day { get; set; }

        public Day DayNavigation { get; set; }
        public Task TaskNavigation { get; set; }
    }
}
