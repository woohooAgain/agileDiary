using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AgileDiary.Data;
using AgileDiary.Models;

namespace AgileDiary.Pages.Goals
{
    public class CreateModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public CreateModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SprintId"] = new SelectList(_context.Sprint, "SprintId", "SprintId");
            return Page();
        }

        [BindProperty]
        public Goal Goal { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Goal.Add(Goal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}