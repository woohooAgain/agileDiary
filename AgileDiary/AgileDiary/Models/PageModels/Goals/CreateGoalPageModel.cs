using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Models.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgileDiary.Models.PageModels.Goals
{
    [Authorize]
    public class CreateGoalPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateGoalPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GoalViewModel Goal { get; set; }

        public IActionResult OnPost()
        {
            //ClaimsPrincipal currentUser = this.User;
            //var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            //Sprint.Creator = currentUserID;
            //_context.Sprint.Add(Sprint.Map());
            //_context.SaveChanges();
            //return RedirectToPage("/Sprints/Index");
            return new ViewResult();
        }
    }
}
