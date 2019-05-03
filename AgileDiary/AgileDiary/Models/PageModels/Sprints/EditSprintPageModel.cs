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
using Microsoft.EntityFrameworkCore;

namespace AgileDiary.Models.PageModels.Sprints
{
    [Authorize]
    public class EditSprintPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditSprintPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SprintViewModel Sprint { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var sprintFromDb = _context.Sprint.FirstOrDefault(s => s.SprintId.Equals(Sprint.Id));
            if (sprintFromDb == null)
            {
                return RedirectToPage("Index");
            }
            sprintFromDb.Reward = Sprint.Reward;
            sprintFromDb.StartDate = Sprint.StartDate;
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { sprintId = Sprint.Id });
            return Redirect(newUrl);
        }

        public IActionResult OnGet(string sprintId)
        {
            var guidSprintId = new Guid(sprintId);
            Sprint = _context.Sprint.Where(s => s.SprintId.Equals(guidSprintId)).Include(s => s.Goals).Select(s => s.Map()).FirstOrDefault();
            return Page();
        }
    }
}