using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using AgileDiary.Helpers.Mappers;

namespace AgileDiary.Models.PageModels.Sprints
{
    public class IndexSprintPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexSprintPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SprintViewModel> Sprints { get; set; }

        public void OnGet()
        {
            Sprints = _context.Sprint.Select(s => s.Map()).ToList();
        }
    }
}
