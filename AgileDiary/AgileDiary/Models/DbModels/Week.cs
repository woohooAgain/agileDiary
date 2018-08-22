using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class Week
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<Day> Days { get; set; }
        public virtual ICollection<SimpleTask> Tasks { get; set; }
        public virtual Result WeekResult { get; set; }
        public virtual Sprint Sprint { get; set; }
    }
}