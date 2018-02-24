using System;

namespace AgileDiary.Models.DB
{
    public class TaskForWeek
    {
        public Guid Task { get; set; }
        public Guid Week { get; set; }

        public Task TaskNavigation { get; set; }
        public Week WeekNavigation { get; set; }
    }
}
