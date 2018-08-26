using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Data;
using AgileDiary.Models.AgileDiaryDBModels;
using AgileDiary.Models.ViewModels;
using AutoMapper;

namespace AgileDiary.Controllers
{
    public class SprintController : Controller
    {
        private readonly AgileDiaryDbContext _context;

        public SprintController(AgileDiaryDbContext context)
        {
            _context = context;
        }

        // GET: Sprint
        public IActionResult Index()
        {
            var model = _context.Sprints.ToList();
            var viewModel = model.Select(Mapper.Map<SprintViewModel>);
            return View("Views/Sprint/Index.cshtml", viewModel);
        }

        // GET: Sprint/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.SprintViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(Mapper.Map<SprintViewModel>(model));
        }

        // GET: Sprint/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sprint/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,Reward")] SprintViewModel sprintViewModel)
        {
            if (ModelState.IsValid)
            {
                var dbModel = Mapper.Map<SprintDbModel>(sprintViewModel);
                _context.Add(dbModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sprintViewModel);
        }

        // GET: Sprint/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sprintViewModel = await _context.Sprints.FindAsync(id);
            if (sprintViewModel == null)
            {
                return NotFound();
            }
            return View(Mapper.Map<SprintViewModel>(sprintViewModel));
        }

        // POST: Sprint/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StartDate,Reward")] SprintViewModel sprintViewModel)
        {
            if (id != sprintViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Mapper.Map<SprintDbModel>(sprintViewModel));
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SprintViewModelExists(sprintViewModel.Id))
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
            return View(sprintViewModel);
        }

        // GET: Sprint/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dbModel = await _context.Sprints
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dbModel == null)
            {
                return NotFound();
            }

            return View(Mapper.Map<SprintViewModel>(dbModel));
        }

        // POST: Sprint/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sprintViewModel = await _context.SprintViewModel.FindAsync(id);
            _context.SprintViewModel.Remove(sprintViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SprintViewModelExists(Guid id)
        {
            return _context.SprintViewModel.Any(e => e.Id == id);
        }
    }
}
