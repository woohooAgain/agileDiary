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
            throw new NotImplementedException();
        }

        public IActionResult OnGet(string sprintId)
        {
            Sprint = _context.Sprint.Where(s => s.SprintId.Equals(new Guid(sprintId))).Select(s => s.Map()).FirstOrDefault();
            return Page();
        }
    }
}