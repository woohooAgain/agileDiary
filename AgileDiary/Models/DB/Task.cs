using System;
using System.Collections.Generic;

namespace AgileDiary.Models.Db
{
    public partial class Task
    {
        public Task()
        {
            TaskForDay = new HashSet<TaskForDay>();
            TaskForWeek = new HashSet<TaskForWeek>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Guid? Goal { get; set; }
        public string Result { get; set; }
        public bool? IsPrimary { get; set; }

        public ICollection<TaskForDay> TaskForDay { get; set; }
        public ICollection<TaskForWeek> TaskForWeek { get; set; }
    }
}
