using System;
using System.Collections.Generic;

namespace AgileDiary.Models.Db
{
    public partial class Sprint
    {
        public Sprint()
        {
            Goal = new HashSet<Goal>();
            Habbit = new HashSet<Habbit>();
            Week = new HashSet<Week>();
        }

        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }
        public string Improvements { get; set; }
        public string Reward { get; set; }

        public ICollection<Goal> Goal { get; set; }
        public ICollection<Habbit> Habbit { get; set; }
        public ICollection<Week> Week { get; set; }
    }
}
