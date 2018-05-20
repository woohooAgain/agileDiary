﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AltAgileDiary.Data;
using AltAgileDiary.Models;
using AltAgileDiary.Models.AgileDiary;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AltAgileDiary.Controllers
{
    [Authorize]
    public class SprintsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public SprintsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Sprints
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            return View(await _context.Sprints.Where(s=>s.OwnerId == currentUser.Id.ToString()).ToListAsync());
        }

        // GET: Sprints/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sprints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Conclusion,Thanks,Improvements,Reward,Start")] Sprint sprint)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                sprint.Id = Guid.NewGuid();
                sprint.End = sprint.Start + TimeSpan.FromDays(62);
                sprint.OwnerId = currentUser.Id;
                _context.Add(sprint);
                await _context.SaveChangesAsync();
                CreateWeeks(sprint.Id, sprint.Start, sprint.End);
                CreateDays(sprint.Weeks.ToArray());
                return View(@"~/Views/Sprints/Edit.cshtml", sprint);
            }
            return View(sprint);
        }

        private void CreateWeeks(Guid sprintId, DateTime startOfSprint, DateTime endOfSprint)
        {
            var currentStart = startOfSprint;
            while (currentStart < endOfSprint)
            {
                _context.Add(new Week(sprintId, currentStart));
                currentStart += TimeSpan.FromDays(7);
            }
            _context.SaveChangesAsync();
        }

        private void CreateDays(Week[] weeks)
        {
            var length = weeks.Length;
            for (var i = 0; i < length; i++)
            {
                var currentDate = weeks[i].Start;
                var weekId = weeks[i].Id;
                while (currentDate <= weeks[i].End)
                {
                    _context.Add(new Day
                    {
                        Date = currentDate,
                        WeekId = weekId
                    });
                    currentDate += TimeSpan.FromDays(1);
                }
                _context.SaveChangesAsync();
            }            
        }

        // GET: Sprints/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var sprint = await _context.Sprints.Include(m => m.Goals).Include(m => m.Habits)
                .Include(m => m.Weeks).SingleOrDefaultAsync(m => m.Id == id);
            if (sprint == null)
            {
                return NotFound();
            }
            return View(sprint);
        }

        // POST: Sprints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Sprint sprint)
        {
            if (id != sprint.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldSprint = await _context.Sprints.FirstOrDefaultAsync(s => s.Id == sprint.Id);
                    oldSprint.Conclusion = sprint.Conclusion;
                    oldSprint.Improvements = sprint.Improvements;
                    oldSprint.Thanks = sprint.Thanks;
                    oldSprint.Reward = sprint.Reward;
                    _context.Update(oldSprint);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SprintExists(sprint.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sprint);
        }

        // GET: Sprints/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprint = await _context.Sprints
                .SingleOrDefaultAsync(m => m.Id == id);
            if (sprint == null)
            {
                return NotFound();
            }

            return View(sprint);
        }

        // POST: Sprints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sprint = await _context.Sprints.SingleOrDefaultAsync(m => m.Id == id);
            _context.Sprints.Remove(sprint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SprintExists(Guid id)
        {
            return _context.Sprints.Any(e => e.Id == id);
        }
    }
}
