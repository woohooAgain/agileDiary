using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Models.ViewModels;
using AgileDiary.Models;

namespace AgileDiary.Helpers.Mappers
{
    public static class WeekMapper
    {
        public static WeekViewModel Map(this Week week)
        {
            return new WeekViewModel
            {
                Id = week.WeekId,
                Conclusion = week.WeekConclusion?.Map(),
                StartDate = week.StartDate.Date,
                TopPriorities = week.TopPriorities?.Select(tp => tp.Map()).ToList(),
                SprintId = week.SprintId,
                EndDate = week.StartDate.ToLocalTime().Date.AddDays(MagicConstants.DaysInWeek - 1)
            };
        }

        public static Week Map(this WeekViewModel week)
        {
            return new Week
            {
                WeekId = week.Id,
                WeekConclusion = (WeekConclusion)week.Conclusion?.Map(),
                StartDate = week.StartDate,
                TopPriorities = week.TopPriorities?.Select(tp => tp.Map()).ToList(),
                SprintId = week.SprintId
            };
        }
    }
}
