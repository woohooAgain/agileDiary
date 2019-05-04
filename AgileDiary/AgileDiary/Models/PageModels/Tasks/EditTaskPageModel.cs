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

namespace AgileDiary.Models.PageModels.Tasks
{
    [Authorize]
    public class EditTaskPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditTaskPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TaskViewModel Task { get; set; }

        public IActionResult OnGet(string taskId)
        {
            var guidTaskId = new Guid(taskId);
            Task = _context.Task.Where(t => t.TaskId.Equals(guidTaskId)).Select(t => t.Map()).FirstOrDefault();
            PrepareGoals();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var taskFromDb = _context.Task.FirstOrDefault(t => t.TaskId.Equals(Task.Id));
            if (taskFromDb == null)
            {
                return RedirectToPage("Index");
            }
            taskFromDb.Title = Task.Title;
            taskFromDb.Description = Task.Description;
            taskFromDb.Date = Task.Date;
            taskFromDb.GoalId = Task.GoalId;
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { taskId = Task.Id });
            return Redirect(newUrl);
        }

        private void PrepareGoals()
        {
            var sprintId = _context.Week.Where(w => w.WeekId.Equals(Task.WeekId)).Select(w => w.SprintId).FirstOrDefault();
            Task.PossibleGoals = _context.Goal.Where(g => g.SprintId.Equals(sprintId)).Select(g => g.GoalId).ToList();
        }
    }
}
