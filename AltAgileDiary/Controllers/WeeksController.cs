using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AltAgileDiary.Data;
using AltAgileDiary.Models.AgileDiary;
using Microsoft.AspNetCore.Authorization;

namespace AltAgileDiary.Controllers
{
    [Authorize]
    public class WeeksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeeksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Weeks/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var week = await _context.Weeks.Include(w => w.Days).SingleOrDefaultAsync(m => m.Id == id);
            if (week == null)
            {
                return NotFound();
            }
            return View(week);
        }

        // POST: Weeks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Week week)
        {
            if (id != week.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var oldWeek = _context.Weeks.FirstOrDefault(d => d.Id == id);
                try
                {
                    oldWeek.Conclusion = week.Conclusion;
                    oldWeek.Thanks = week.Thanks;
                    _context.Update(oldWeek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeekExists(week.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var sprint = await _context.Sprints.Include(m => m.Goals).Include(m => m.Habits)
                    .Include(m => m.Weeks).SingleOrDefaultAsync(m => m.Id == oldWeek.SprintId);
                return View(@"~/Views/Sprints/Edit.cshtml", sprint);
            }
            return View(week);
        }

        private bool WeekExists(Guid id)
        {
            return _context.Weeks.Any(e => e.Id == id);
        }
    }
}
