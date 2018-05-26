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
    public class HabitsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HabitsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Habits/Create
        [HttpGet]
        [Route("Habits/Create/{sprintId}")]
        public IActionResult Create(string sprintId)
        {
            //ViewData["SprintId"] = new SelectList(_context.Sprints, "Id", "Id");
            //return View();
            var id = new Guid(sprintId);
            var habit = new Habit
            {
                SprintId = id
            };
            return View(habit);
        }

        // POST: Habits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,MaxChainLength,Total,SprintId")] Habit habit)
        {
            if (ModelState.IsValid)
            {
                habit.Id = Guid.NewGuid();
                _context.Add(habit);
                await _context.SaveChangesAsync();                
                var sprint = await _context.Sprints.Include(m => m.Goals).Include(m => m.Habits)
                    .Include(m => m.Weeks).SingleOrDefaultAsync(m => m.Id == habit.SprintId);
                CreateDailyResults(habit.Id, sprint.Start);
                return View(@"~/Views/Sprints/Edit.cshtml", sprint);
            }
            return View(habit);
        }

        private void CreateDailyResults(Guid habitId, DateTime startDate)
        {
            const int daysQuantity = 63;
            var date = startDate;
            for (var i = 0; i < daysQuantity; i++)
            {
                var currentDayId = _context.Day.FirstOrDefault(d => d.Date == date).Id;
                _context.Add(new DailyHabitResult
                {
                    Done = false,
                    HabitId = habitId,
                    DayId = currentDayId
                });
                date = date.AddDays(1);
            }
            _context.SaveChangesAsync();
        }

        // GET: Habits/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habit = await _context.Habit.SingleOrDefaultAsync(m => m.Id == id);
            if (habit == null)
            {
                return NotFound();
            }
            ViewData["SprintId"] = new SelectList(_context.Sprints, "Id", "Id", habit.SprintId);
            return View(habit);
        }

        // POST: Habits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Title,MaxChainLength,Total,SprintId")] Habit habit)
        {
            if (id != habit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabitExists(habit.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var sprint = await _context.Sprints.Include(m => m.Goals).Include(m => m.Habits)
                    .Include(m => m.Weeks).SingleOrDefaultAsync(m => m.Id == habit.SprintId);
                return View(@"~/Views/Sprints/Edit.cshtml", sprint);
            }
            ViewData["SprintId"] = new SelectList(_context.Sprints, "Id", "Id", habit.SprintId);
            return View(habit);
        }

        private bool HabitExists(Guid id)
        {
            return _context.Habit.Any(e => e.Id == id);
        }
    }
}
