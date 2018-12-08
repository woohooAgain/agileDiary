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
    public class IndexModel : PageModel
    {
        private readonly AgileDiary.Data.ApplicationDbContext _context;

        public IndexModel(AgileDiary.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Sprint> Sprint { get;set; }

        public async Task OnGetAsync()
        {
            Sprint = await _context.Sprint.ToListAsync();
        }
    }
}
