using System;

namespace AgileDiary.Models.ViewModels
{
    public class MilestoneViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public virtual WeekViewModel Week { get; set; }
    }
}
