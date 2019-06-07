using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Helpers.Mappers;

namespace AgileDiary.Models.PageModels.Weeks
{
    [Authorize]
    public class SprintWeeksPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public SprintWeeksPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<WeekViewModel> Weeks { get; set; }
        [BindProperty]
        public Guid SprintId { get; set; }

        public void OnGet(string sprintId)
        {
            var guidSprintId = new Guid(sprintId);
            Weeks = _context.Week.Where(w => w.SprintId.Equals(guidSprintId)).Select(w => w.Map()).OrderBy(w => w.StartDate).ToList();
            SprintId = guidSprintId;
        }
    }
}
