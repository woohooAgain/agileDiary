using System;
using System.Collections.Generic;

namespace AgileDiary.Models.Db
{
    public partial class Goal
    {
        public Goal()
        {
            Milestone = new HashSet<Milestone>();
        }

        public Guid Id { get; set; }
        public string Reason { get; set; }
        public string Result { get; set; }
        public string Description { get; set; }
        public Guid Sprint { get; set; }

        public Sprint SprintNavigation { get; set; }
        public ICollection<Milestone> Milestone { get; set; }
    }
}
