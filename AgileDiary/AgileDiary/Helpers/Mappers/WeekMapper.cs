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
            var dayList = new List<DayViewModel>();
            for(var i = 0; i< MagicConstants.DaysInWeek; i++)
            {
                dayList.Add(new DayViewModel
                {
                    Date = week.StartDate.Date.AddDays(i)
                });
            }
            if (week.Tasks != null)
            {
                foreach (var task in week.Tasks)
                {
                    var suitableDay = dayList.FirstOrDefault(d => d.Date.Equals(task.Date));
                    //todo: Investigate problem with dates
                    if (suitableDay == null)
                    {
                        continue;
                    }
                    if (suitableDay.Tasks == null)
                    {
                        suitableDay.Tasks = new List<TaskViewModel>();
                    }
                    suitableDay.Tasks.Add(task.Map());
                }
            }            
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
            var taskList = new List<Models.Task>();
            if (week.Days != null)
            {
                foreach (var day in week.Days)
                {
                    taskList.AddRange(day.Tasks.Select(t => t.Map()));
                }
            }            
            return new Week
            {
                WeekId = week.Id,
                WeekConclusion = (WeekConclusion)week.Conclusion?.Map(),
                StartDate = week.StartDate,
                TopPriorities = week.TopPriorities?.Select(tp => tp.Map()).ToList(),
                SprintId = week.SprintId,
                Tasks = taskList
            };
        }
    }
}

                EndDate = week.StartDate.ToLocalTime().Date.AddDays(MagicConstants.DaysInWeek - 1),
                Days = dayList