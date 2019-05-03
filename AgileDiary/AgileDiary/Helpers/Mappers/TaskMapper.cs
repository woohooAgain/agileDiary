using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Models.ViewModels;

namespace AgileDiary.Helpers.Mappers
{
    public static class TaskMapper
    {
        public static Models.Task Map(this TaskViewModel task)
        {
            return new Models.Task
            {
                TaskId = task.Id,
                Date = task.Date,
                Description = task.Description,
                Title = task.Title,
                WeekId = task.WeekId
            };
        }

        public static TaskViewModel Map(this Models.Task task)
        {
            return new TaskViewModel
            {
                Id = task.TaskId,
                Date = task.Date,
                Description = task.Description,
                Title = task.Title,
                WeekId = task.WeekId
            };
        }
    }
}
