using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class HabitDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<HabitResultDbModel> HabitResults { get; set; }
        public virtual SprintDbModel SprintDbModel { get; set; }
    }
}
