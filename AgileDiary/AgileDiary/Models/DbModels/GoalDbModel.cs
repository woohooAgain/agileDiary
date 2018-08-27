using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class GoalDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<MilestoneDbModel> Milestones { get; set; }
        public virtual SprintDbModel Sprint { get; set; }
    }
}
