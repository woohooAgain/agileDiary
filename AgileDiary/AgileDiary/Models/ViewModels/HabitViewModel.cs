using System;
using System.Collections.Generic;

namespace AgileDiary.Models.ViewModels
{
    public class HabitViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<HabitResultViewModel> HabitResults { get; set; }
        public virtual SprintViewModel Sprint { get; set; }
    }
}
