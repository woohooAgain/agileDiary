using System;

namespace AgileDiary.Models.ViewModels
{
    public class SimpleTaskViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Finished { get; set; }

        public virtual DayViewModel Day { get; set; }
        public virtual WeekViewModel Week { get; set; }
        public virtual GoalViewModel Goal { get; set; }
    }
}
