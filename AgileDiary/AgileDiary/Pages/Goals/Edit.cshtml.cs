using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Data;
using AgileDiary.Models;

namespace AgileDiary.Pages.Goals
{
    public class EditModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public EditModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Goal Goal { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Goal = await _context.Goal
                .Include(g => g.Sprint).FirstOrDefaultAsync(m => m.GoalId == id);

            if (Goal == null)
            {
                return NotFound();
            }
           ViewData["SprintId"] = new SelectList(_context.Sprint, "SprintId", "SprintId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Goal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoalExists(Goal.GoalId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GoalExists(Guid id)
        {
            return _context.Goal.Any(e => e.GoalId == id);
        }
    }
}
