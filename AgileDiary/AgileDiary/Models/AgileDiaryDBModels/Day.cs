using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class Day
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<SimpleTask> Tasks { get; set; }
        public virtual Week Week { get; set; }
        public virtual Result DayResult { get; set; }
        public virtual ICollection<HabitResult> HabitResults { get; set; }
    }
}
