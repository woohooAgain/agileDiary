﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AltAgileDiary.Data;
using AltAgileDiary.Models.AgileDiary;

namespace AltAgileDiary.Controllers
{
    public class SprintsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SprintsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sprints
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sprints.ToListAsync());
        }

        // GET: Sprints/Details/5
        public async Task<IActionResult> Details(Guid? id)
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
                sprint.Id = Guid.NewGuid();
                sprint.End = sprint.Start + TimeSpan.FromDays(62);
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
                while (currentDate <= weeks[i].End)
                {
                    _context.Add(new Day
                    {
                        Date = currentDate,
                        WeekId = weeks[i].Id
                    });
                    currentDate += TimeSpan.FromDays(1);
                }
            }
            _context.SaveChangesAsync();
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
                    sprint.End = sprint.Start + TimeSpan.FromDays(62);
                    _context.Update(sprint);
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
