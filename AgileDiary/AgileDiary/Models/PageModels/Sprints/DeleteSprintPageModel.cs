using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using AgileDiary.Helpers.Mappers;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AgileDiary.Models.PageModels.Sprints
{
    [Authorize]
    public class DeleteSprintPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteSprintPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string sprintId)
        {
            var guidSprintId = new Guid(sprintId);
            var sprint = _context.Sprint.FirstOrDefault(s => s.SprintId.Equals(guidSprintId));
            _context.Remove(sprint);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
