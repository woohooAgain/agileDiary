using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class SimpleTaskDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Finished { get; set; }

        public virtual DayDbModel DayDbModel { get; set; }
        public virtual WeekDbModel WeekDbModel { get; set; }
        public virtual GoalDbModel GoalDbModel { get; set; }
    }
}
