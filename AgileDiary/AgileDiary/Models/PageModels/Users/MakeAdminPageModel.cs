using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.PageModels.Users
{
    public class MakeAdminPageModel : PageModel
    {
        private UserManager<IdentityRole> _userManager;

        public MakeAdminPageModel(UserManager<IdentityRole> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult OnGet(string userId)
        {
            var guidId = new Guid(userId);
            var user = _userManager.Users.First(u => u.Id.Equals(guidId));
            _userManager.AddToRoleAsync(user, "admin").Wait();
            return RedirectToPage("Index");
        }
    }
}
