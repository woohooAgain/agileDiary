using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class Milestone
    {
        public Milestone()
        {
            Goal = new HashSet<Goal>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public ICollection<Goal> Goal { get; set; }
    }
}
