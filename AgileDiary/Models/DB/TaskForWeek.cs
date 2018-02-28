using System;
using System.Collections.Generic;

namespace AgileDiary.Models.db
{
    public partial class TaskForWeek
    {
        public Guid Task { get; set; }
        public Guid Week { get; set; }

        public Task TaskNavigation { get; set; }
        public Week WeekNavigation { get; set; }
    }
}
