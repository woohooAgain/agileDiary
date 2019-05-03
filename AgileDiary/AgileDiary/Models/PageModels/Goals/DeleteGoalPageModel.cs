using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgileDiary.Models.PageModels.Goals
{
    [Authorize]
    public class DeleteGoalPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteGoalPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string goalId)
        {
            var guidGoalId = new Guid(goalId);
            var goal = _context.Goal.FirstOrDefault(s => s.GoalId.Equals(guidGoalId));
            var sprintId = goal.SprintId;
            _context.Remove(goal);
            _context.SaveChanges();
            var url = Url.Page("SprintGoals", new { sprintId = sprintId.ToString() });
            return Redirect(url);
        }
    }
}
