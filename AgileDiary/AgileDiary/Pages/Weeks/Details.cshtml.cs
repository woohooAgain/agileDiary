using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Data;
using AgileDiary.Models;

namespace AgileDiary.Pages.Weeks
{
    public class DetailsModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public DetailsModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
