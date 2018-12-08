using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AgileDiary.Data;
using AgileDiary.Models;

namespace AgileDiary.Pages.Weeks
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
        public Week Week { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Week.Add(Week);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}