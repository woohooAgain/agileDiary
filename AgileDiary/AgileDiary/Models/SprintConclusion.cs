using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models
{
    public class SprintConclusion
    {
        public Guid SprintConclusionId { get; set; }
        public string Achievment { get; set; }
        public string Thanks { get; set; }
        public string Lesson { get; set; }
        public string Improvement { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }
    }
}
