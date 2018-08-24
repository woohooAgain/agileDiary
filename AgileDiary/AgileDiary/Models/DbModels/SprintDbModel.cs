using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class SprintDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public string Reward { get; set; }

        public virtual ICollection<WeekDbModel> Weeks { get; set; }
        public virtual ICollection<GoalDbModel> Goals { get; set; }
        public virtual ResultDbModel SprintResultDbModel { get; set; }
        public virtual ICollection<HabitDbModel> Habits { get; set; }
    }
}
