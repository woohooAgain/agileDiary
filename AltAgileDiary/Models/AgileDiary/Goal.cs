using System;
using System.Collections.Generic;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Goal
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
        public string Result { get; set; }
        public string Description { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
