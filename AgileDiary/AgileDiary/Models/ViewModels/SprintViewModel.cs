using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgileDiary.Data;

namespace AgileDiary.Models.ViewModels
{
    public class SprintViewModel : PageModel
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reward { get; set; }
        public List<WeekViewModel> Weeks { get; set; }
        public List<GoalViewModel> Goals { get; set; }
        public ConclusionViewModel Conclusion { get; set; }
        public SprintStatus Status { get; set; }
        public string Creator { get; set; }
    }

    public enum SprintStatus
    {
        Planned,
        InProcess,
        Finished
    }
}
