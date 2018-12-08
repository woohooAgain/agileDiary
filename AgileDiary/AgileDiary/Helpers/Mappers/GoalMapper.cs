using AgileDiary.Models.ViewModels;
using AgileDiary.Models;
using System.Linq;

namespace AgileDiary.Helpers.Mappers
{
    public static class GoalMapper
    {
        public static GoalViewModel Map(this Goal goal)
        {
            return new GoalViewModel
            {
                Id = goal.GoalId,
                Title = goal.Title,
                Description = goal.Description,
                Result = goal.Result,
                Milestones = goal.Milestones.Select(m => m.Map()).ToList(),
                SprintId = goal.SprintId
            };
        }

        public static Goal Map(this GoalViewModel goal)
        {
            return new Goal
            {
                GoalId = goal.Id,
                Title = goal.Title,
                Description = goal.Description,
                Result = goal.Result,
                Milestones = goal.Milestones.Select(m => m.Map()).ToList(),
                SprintId = goal.SprintId
            };
        }
    }
}
