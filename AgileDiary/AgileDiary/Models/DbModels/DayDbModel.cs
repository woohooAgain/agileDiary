using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class DayDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<SimpleTaskDbModel> Tasks { get; set; }
        public virtual WeekDbModel WeekDbModel { get; set; }
        public virtual ResultDbModel DayResultDbModel { get; set; }
        public virtual ICollection<HabitResultDbModel> HabitResults { get; set; }
    }
}
