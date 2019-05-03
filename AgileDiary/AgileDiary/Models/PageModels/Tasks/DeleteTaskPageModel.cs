using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using Microsoft.AspNetCore.Mvc;

namespace AgileDiary.Models.PageModels.Tasks
{
    [Authorize]
    public class DeleteTaskPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteTaskPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string taskId)
        {
            var guidTaskId = new Guid(taskId);
            var task = _context.Task.FirstOrDefault(t => t.TaskId.Equals(guidTaskId));
            var weekId = task.WeekId;
            _context.Remove(task);
            _context.SaveChanges();
            var url = Url.Page("/Weeks/Edit", new { weekId = weekId.ToString() });
            return Redirect(url);
        }
    }
}
