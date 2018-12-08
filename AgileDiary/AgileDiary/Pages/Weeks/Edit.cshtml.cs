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

namespace AgileDiary.Pages.Weeks
{
    public class EditModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public EditModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Week Week { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Week = await _context.Week
                .Include(w => w.Sprint).FirstOrDefaultAsync(m => m.WeekId == id);

            if (Week == null)
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

            _context.Attach(Week).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeekExists(Week.WeekId))
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

        private bool WeekExists(Guid id)
        {
            return _context.Week.Any(e => e.WeekId == id);
        }
    }
}
