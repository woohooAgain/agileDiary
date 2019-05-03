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
using Microsoft.EntityFrameworkCore;

namespace AgileDiary.Models.PageModels.Weeks
{
    [Authorize]
    public class EditWeekPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditWeekPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WeekViewModel Week { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var weekFromDb = _context.Week.Include(w => w.Tasks).FirstOrDefault(w => w.WeekId.Equals(Week.Id));
            if (weekFromDb == null)
            {
                return RedirectToPage("Index");
            }
            weekFromDb = Week.Map();
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { weekId = Week.Id });
            return Redirect(newUrl);
        }

        public IActionResult OnGet(string weekId)
        {
            var guidGoalId = new Guid(weekId);
            Week = _context.Week.Where(w => w.WeekId.Equals(guidGoalId)).Include(w => w.Tasks).Select(w => w.Map()).FirstOrDefault();
            return Page();
        }

        public IActionResult OnGetTask(string weekId, DateTime date)
        {
            var weekFromDb = _context.Week.Include(w => w.Tasks).FirstOrDefault(w => w.WeekId.Equals(new Guid(weekId)));
            weekFromDb.Tasks.Add(new Task
            {
                TaskId = Guid.NewGuid(),
                Date = date,
                Title = "Default task title",
                Description = "Default task description"
            });
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { weekId = weekId });
            return Redirect(newUrl);
        }
    }
}
