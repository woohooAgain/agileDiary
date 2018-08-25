using System;
using System.Collections.Generic;

namespace AgileDiary.Models.ViewModels
{
    public class DayViewModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<SimpleTaskViewModel> Tasks { get; set; }
        public virtual WeekViewModel Week { get; set; }
        public virtual ResultViewModel DayResult { get; set; }
        public virtual ICollection<HabitResultViewModel> HabitResults { get; set; }
    }
}
