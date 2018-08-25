using System;
using System.Collections.Generic;

namespace AgileDiary.Models.ViewModels
{
    public class WeekViewModel
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }

        public virtual ICollection<DayViewModel> Days { get; set; }
        public virtual ICollection<SimpleTaskViewModel> Tasks { get; set; }
        public virtual ResultViewModel WeekResult { get; set; }
        public virtual SprintViewModel Sprint { get; set; }
    }
}