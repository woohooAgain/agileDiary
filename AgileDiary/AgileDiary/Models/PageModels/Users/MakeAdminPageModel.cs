using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using AgileDiary.Helpers.MagicConstants;

namespace AgileDiary.Models.PageModels.Users
{
    public class MakeAdminPageModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public MakeAdminPageModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult OnGet(string userId)
        {
            var user = _userManager.Users.First(u => u.Id.Equals(userId));
            _userManager.AddToRoleAsync(user, MagicStrings.AdminRole).Wait();
            return RedirectToPage("Index");
        }
    }
}
