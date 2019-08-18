using AgileDiary.Helpers.Mappers;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace AgileDiary.Models.PageModels.Users
{
    public class CreateUserPageModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public CreateUserPageModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public UserViewModel NewUser { get; set; }

        public IActionResult OnGet()
        {
            NewUser = new UserViewModel();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            var dbUser = NewUser.Map();
            var userResult = await _userManager.CreateAsync(dbUser);
            if (!string.IsNullOrEmpty(NewUser.Role))
            {
                var roleResult = await _userManager.AddToRoleAsync(dbUser, NewUser.Role);
            }            
            return RedirectToPage("Index");
        }
    }
}
