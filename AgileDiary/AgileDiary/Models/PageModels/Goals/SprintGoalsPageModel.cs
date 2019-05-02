﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using AgileDiary.Data;
using AgileDiary.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Helpers.Mappers;

namespace AgileDiary.Models.PageModels.Goals
{
    [Authorize]
    public class SprintGoalsPageModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public SprintGoalsPageModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<GoalViewModel> Goals { get; set; }

        public void OnGet(string sprintId)
        {
            Goals = _context.Goal.Where(s => s.SprintId.Equals(sprintId)).Select(g => g.Map()).ToList();
        }
    }
}
