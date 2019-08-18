using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgileDiary.Models.PageModels.Users
{
    public class DeleteUserPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DeleteUserPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string userId)
        {
            var user = _context.Users.FirstOrDefault(s => s.Id.Equals(userId));
            _context.Remove(user);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
