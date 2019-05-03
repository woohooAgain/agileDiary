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
    public class CreateSprintPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateSprintPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SprintViewModel Sprint { get; set; }

        public IActionResult OnPost()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Sprint.Id = Guid.NewGuid();
            Sprint.Creator = currentUserID;
            Sprint.PrepareInitialGoals();
            Sprint.PrepareWeeks();
            _context.Sprint.Add(Sprint.Map());
            _context.SaveChanges();
            var newUrl = Url.Page("Edit", new { sprintId = Sprint.Id });
            return Redirect(newUrl);
        }

        public IActionResult OnGet()
        {
            Sprint = new SprintViewModel();
            return Page();
        }
    }
}
