using System;
using System.Collections.Generic;

namespace AgileDiary.Models.ViewModels
{
    public class SprintViewModel
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate => StartDate.AddDays(63);
        public string Reward { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<WeekViewModel> Weeks { get; set; }
        public virtual ICollection<GoalViewModel> Goals { get; set; }
        public virtual ResultViewModel SprintResult { get; set; }
        public virtual ICollection<HabitViewModel> Habits { get; set; }
    }
}
