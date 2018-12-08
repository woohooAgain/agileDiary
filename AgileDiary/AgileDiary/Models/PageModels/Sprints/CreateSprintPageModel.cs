using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using AgileDiary.Helpers.Mappers;

namespace AgileDiary.Models.PageModels.Sprints
{
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Sprint.Add(Sprint.Map());
            _context.SaveChanges();
            return RedirectToPage("/Sprints/Index");
        }
    }
}
