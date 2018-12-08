using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Data;
using AgileDiary.Models;

namespace AgileDiary.Pages.Sprints
{
    public class DetailsModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public DetailsModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
