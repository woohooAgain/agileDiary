using System.Collections.Generic;
using System.Linq;
using AgileDiary.Data;
using AgileDiary.Helpers.Mappers;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace AgileDiary.Models.PageModels.Users
{
    [Authorize(Roles = "admin")]
    public class IndexUsersPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IndexUsersPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<UserViewModel> Users { get; set; }

        public void OnGet()
        {
            Users = _context.Users.Select(u => u.Map()).ToList();
        }
    }
}