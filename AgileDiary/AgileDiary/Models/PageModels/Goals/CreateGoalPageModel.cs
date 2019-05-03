using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgileDiary.Helpers.Mappers;

namespace AgileDiary.Models.PageModels.Goals
{
    [Authorize]
    public class CreateGoalPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateGoalPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GoalViewModel Goal { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Goal.Id = Guid.NewGuid();
            var sprint = _context.Sprint.FirstOrDefault(s => s.SprintId.Equals(Goal.SprintId));
            var dbGoal = Goal.Map();
            _context.Goal.Add(dbGoal);
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { goalId = Goal.Id });
            return Redirect(newUrl);
        }

        public IActionResult OnGet(string sprintId)
        {
            Goal = new GoalViewModel();
            Goal.SprintId = new Guid(sprintId);
            return Page();
        }
    }
}
