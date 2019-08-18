using System;
using System.Linq;
using AgileDiary.Models.ViewModels;
using AgileDiary.Models;
using AgileDiary.Data;

namespace AgileDiary.Helpers.Mappers
{
    public static class SprintMapper
    {
        public static SprintViewModel Map(this Sprint sprint)
        {
            var startDate = sprint.StartDate.ToLocalTime().Date;
            var endDate = sprint.StartDate.ToLocalTime().Date.AddDays(MagicNumbers.NumberOfWeeks*MagicNumbers.DaysInWeek);
            return new SprintViewModel()
            {
                Id = sprint.SprintId,
                Reward = sprint.Reward,
                StartDate = startDate,
                EndDate = endDate,
                Conclusion = sprint.SprintConclusion?.Map(),
                Goals = sprint.Goals?.Select(g => g.Map()).ToList(),
                Weeks = sprint.Weeks?.Select(w => w.Map()).ToList(),
                Status = CalculateStatus(startDate, endDate),
                Creator = sprint.Creator
            };
        }

        public static Sprint Map(this SprintViewModel sprint)
        {
            return new Sprint
            {
                SprintId = sprint.Id,
                Reward = sprint.Reward,
                StartDate = sprint.StartDate.ToUniversalTime(),
                SprintConclusion = (SprintConclusion)sprint.Conclusion?.Map(),
                Goals = sprint.Goals?.Select(g => g.Map()).ToList(),
                Weeks = sprint.Weeks?.Select(w => w.Map()).ToList(),
                Creator = sprint.Creator
            };
        }

        private static SprintStatus CalculateStatus(DateTime start, DateTime end)
        {
            var now = DateTime.UtcNow.ToLocalTime();
            return now < start ? SprintStatus.Planned :
                   now < end ? SprintStatus.InProcess : SprintStatus.Finished;
        }
    }
}
