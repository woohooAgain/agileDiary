using System;

namespace AgileDiary.Models.ViewModels
{
    public class TaskViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Guid WeekId { get; set; }
    }
}