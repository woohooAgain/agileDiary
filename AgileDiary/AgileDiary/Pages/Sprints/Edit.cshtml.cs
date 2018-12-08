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

namespace AgileDiary.Pages.Sprints
{
    public class EditModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public EditModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sprint Sprint { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sprint = await _context.Sprint.FirstOrDefaultAsync(m => m.SprintId == id);

            if (Sprint == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sprint).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SprintExists(Sprint.SprintId))
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

        private bool SprintExists(Guid id)
        {
            return _context.Sprint.Any(e => e.SprintId == id);
        }
    }
}
