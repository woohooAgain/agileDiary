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
        private readonly UserManager<IdentityUser> _userManager;

        public IndexUsersPageModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<UserViewModel> Users { get; set; }

        public async void OnGet()
        {
            Users = new List<UserViewModel>();
            var users = _context.Users;
            foreach(var u in users)
            {
                var user = u.Map();
                var roles = await _userManager.GetRolesAsync(u);
                user.Role = roles.FirstOrDefault();
                Users.Add(user);
            }
        }
    }
}