using AgileDiary.Helpers.Mappers;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public IActionResult OnPost()
        {
            var dbUser = NewUser.Map();
            _userManager.CreateAsync(dbUser).Wait();
            if (!string.IsNullOrEmpty(NewUser.Role))
            {
                _userManager.AddToRoleAsync(dbUser, NewUser.Role).Wait();
            }            
            return RedirectToPage("Index");
        }
    }
}
