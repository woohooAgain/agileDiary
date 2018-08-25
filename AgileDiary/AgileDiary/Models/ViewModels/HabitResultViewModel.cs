using System;

namespace AgileDiary.Models.ViewModels
{
    public class HabitResultViewModel
    {
        public Guid Id { get; set; }
        public bool Done { get; set; }

        public virtual HabitViewModel Habit { get; set; }
        public virtual DayViewModel Day { get; set; }
    }
}
