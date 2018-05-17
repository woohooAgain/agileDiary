using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AltAgileDiary.Data;
using AltAgileDiary.Data.Migrations;
using AltAgileDiary.Models.AgileDiary;

namespace AltAgileDiary.Controllers
{
    public class GoalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GoalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Goals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Goal.ToListAsync());
        }

        // GET: Goals/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goal = await _context.Goal
                .SingleOrDefaultAsync(m => m.Id == id);
            if (goal == null)
            {
                return NotFound();
            }

            return View(goal);
        }

        // GET: Goals/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        [HttpGet]
        [Route("Goals/Create/{sprintId}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string sprintId)
        {
            var id = new Guid(sprintId);
            var goal = new Goal
            {
                SprintId = id
            };
            return View(goal);
        }

        // POST: Goals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Goal goal)
        {
            if (ModelState.IsValid)
            {
                goal.Id = Guid.NewGuid();
                _context.Add(goal);
                await _context.SaveChangesAsync();
                var sprint = await _context.Sprints.Include(m => m.Goals).Include(m => m.Habits)
                    .Include(m => m.Weeks).SingleOrDefaultAsync(m => m.Id == goal.SprintId);
                return View(@"~/Views/Sprints/Edit.cshtml", sprint);
            }
            return View(goal);
        }

        // GET: Goals/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goal = await _context.Goal.SingleOrDefaultAsync(m => m.Id == id);
            if (goal == null)
            {
                return NotFound();
            }
            return View(goal);
        }

        // POST: Goals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Reason,Result,Description,SprintId")] Goal goal)
        {
            if (id != goal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoalExists(goal.Id))
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
            return View(goal);
        }

        // GET: Goals/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goal = await _context.Goal
                .SingleOrDefaultAsync(m => m.Id == id);
            if (goal == null)
            {
                return NotFound();
            }

            return View(goal);
        }

        // POST: Goals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var goal = await _context.Goal.SingleOrDefaultAsync(m => m.Id == id);
            _context.Goal.Remove(goal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoalExists(Guid id)
        {
            return _context.Goal.Any(e => e.Id == id);
        }
    }
}
