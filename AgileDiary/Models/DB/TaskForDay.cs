using System;
using System.Collections.Generic;

namespace AgileDiary.Models.Db
{
    public partial class TaskForDay
    {
        public Guid Task { get; set; }
        public Guid Day { get; set; }

        public Day DayNavigation { get; set; }
        public Task TaskNavigation { get; set; }
    }
}
