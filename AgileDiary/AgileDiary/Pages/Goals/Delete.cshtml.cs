using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Data;
using AgileDiary.Models;

namespace AgileDiary.Pages.Goals
{
    public class DeleteModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public DeleteModel(AgileDiary.Data.ApplicationDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Goal = await _context.Goal.FindAsync(id);

            if (Goal != null)
            {
                _context.Goal.Remove(Goal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
