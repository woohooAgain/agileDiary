﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models
{
    public class Goal
    {
        public Guid GoalId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Milestone> Milestones { get; set; }
        public string Result { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }
    }
}
