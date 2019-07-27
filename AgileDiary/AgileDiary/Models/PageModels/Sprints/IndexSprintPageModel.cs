using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using AgileDiary.Helpers.Mappers;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
            var roles = _context.Roles.ToList();
            var userRoles = _context.UserRoles.ToList();
            var users = _context.Users.ToList();
            var userClaims = _context.UserClaims.ToList();
            var roleClaims = _context.RoleClaims.ToList();
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            Sprints = _context.Sprint.Where(s=>s.Creator.Equals(currentUserID)).Select(s => s.Map()).ToList();
        }
    }
}
