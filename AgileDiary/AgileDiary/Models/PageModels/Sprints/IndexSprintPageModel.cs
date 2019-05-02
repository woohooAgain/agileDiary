using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using AgileDiary.Helpers.Mappers;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgileDiary.Models.PageModels.Sprints
{
    [Authorize]
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
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            Sprints = _context.Sprint.Where(s=>s.Creator.Equals(currentUserID)).Select(s => s.Map()).ToList();
        }
    }
}
