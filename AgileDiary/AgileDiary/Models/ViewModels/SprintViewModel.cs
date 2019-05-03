using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgileDiary.Data;
using AgileDiary.Helpers;

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

        internal void PrepareInitialGoals()
        {
            Goals = new List<GoalViewModel> {
                new GoalViewModel
                {
                    Id = Guid.NewGuid(),
                    SprintId = Id,
                    Title = "Default goal",
                    Description = "Default description",
                    Result = "Default result"
                },
                new GoalViewModel
                {
                    Id = Guid.NewGuid(),
                    SprintId = Id,
                    Title = "Default goal",
                    Description = "Default description",
                    Result = "Default result"
                },
                new GoalViewModel
                {
                    Id = Guid.NewGuid(),
                    SprintId = Id,
                    Title = "Default goal",
                    Description = "Default description",
                    Result = "Default result"
                }
            };
        }

        internal void PrepareWeeks()
        {
            Weeks = new List<WeekViewModel>();
            for (var i = 0; i < MagicConstants.NumberOfWeeks; i++)
            {
                var defaultWeek = new WeekViewModel
                {
                    SprintId = Id,
                    StartDate = StartDate.AddDays(i * MagicConstants.DaysInWeek),
                    Id = Guid.NewGuid()
                };
                Weeks.Add(defaultWeek);
            }
        }
    }

    public enum SprintStatus
    {
        Planned,
        InProcess,
        Finished
    }
}
