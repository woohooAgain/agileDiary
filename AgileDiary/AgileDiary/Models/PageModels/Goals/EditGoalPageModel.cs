using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Helpers.Mappers;

namespace AgileDiary.Models.PageModels.Goals
{
    [Authorize]
    public class EditGoalPageModel : PageModel
    {
        private ApplicationDbContext _context;
        public EditGoalPageModel(ApplicationDbContext context)
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
            var goalFromDb = _context.Goal.FirstOrDefault(g => g.GoalId.Equals(Goal.Id));
            if (goalFromDb == null)
            {
                return RedirectToPage("Index");
            }
            goalFromDb.Title = Goal.Title;
            goalFromDb.Description = Goal.Description;
            goalFromDb.Result = Goal.Result;
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { goalId = Goal.Id });
            return Redirect(newUrl);
        }

        public IActionResult OnGet(string goalId)
        {
            var guidGoalId = new Guid(goalId);
            Goal = _context.Goal.Where(s => s.GoalId.Equals(guidGoalId)).Select(g => g.Map()).FirstOrDefault();
            return Page();
        }
    }
}
