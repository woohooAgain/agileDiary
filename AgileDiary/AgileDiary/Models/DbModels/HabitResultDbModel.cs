using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class HabitResultDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public bool Done { get; set; }

        public virtual HabitDbModel Habit { get; set; }
        public virtual DayDbModel Day { get; set; }
    }
}
