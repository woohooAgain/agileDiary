using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class WeekDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<DayDbModel> Days { get; set; }
        public virtual ICollection<SimpleTaskDbModel> Tasks { get; set; }
        public virtual ResultDbModel WeekResultDbModel { get; set; }
        public virtual SprintDbModel SprintDbModel { get; set; }
    }
}