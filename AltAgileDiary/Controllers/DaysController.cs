using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AltAgileDiary.Data;
using AltAgileDiary.Models.AgileDiary;
using Microsoft.AspNetCore.Authorization;

namespace AltAgileDiary.Controllers
{
    [Authorize]
    public class DaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Days/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var day = await _context.Day.SingleOrDefaultAsync(m => m.Id == id);
            if (day == null)
            {
                return NotFound();
            }
            ViewData["WeekId"] = new SelectList(_context.Weeks, "Id", "Id", day.WeekId);
            return View(day);
        }

        // POST: Days/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Day day)
        {
            if (id != day.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var oldDay = _context.Day.FirstOrDefault(d => d.Id == id);
                try
                {
                    oldDay.Achievements = day.Achievements;
                    oldDay.Thanks = day.Thanks;
                    _context.Update(oldDay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DayExists(day.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var week = await _context.Weeks.Include(w => w.Days).SingleOrDefaultAsync(w => w.Id == oldDay.WeekId);
                return View(@"~/Views/Weeks/Edit.cshtml", week);
            }
            ViewData["WeekId"] = new SelectList(_context.Weeks, "Id", "Id", day.WeekId);
            return View(day);
        }

        private bool DayExists(Guid id)
        {
            return _context.Day.Any(e => e.Id == id);
        }
    }
}
