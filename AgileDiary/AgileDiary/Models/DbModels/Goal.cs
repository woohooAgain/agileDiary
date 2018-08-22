using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class Goal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<Milestone> Milestones { get; set; }
        public virtual Sprint Sprint { get; set; }
    }
}
