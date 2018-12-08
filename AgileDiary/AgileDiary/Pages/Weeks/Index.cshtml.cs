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
    public class IndexModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public IndexModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Week> Week { get;set; }

        public async Task OnGetAsync()
        {
            Week = await _context.Week
                .Include(w => w.Sprint).ToListAsync();
        }
    }
}
