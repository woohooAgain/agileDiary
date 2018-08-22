using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class Habit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<HabitResult> HabitResults { get; set; }
        public virtual Sprint Sprint { get; set; }
    }
}
