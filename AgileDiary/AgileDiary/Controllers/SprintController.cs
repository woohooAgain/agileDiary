using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgileDiary.Interfaces;
using AgileDiary.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace AgileDiary.Controllers
{
    [Authorize]
    public class SprintController : Controller
    {
        private readonly ISprintServiceCrud _sprintServiceCrud;

        public SprintController(ISprintServiceCrud sprintServiceCrud)
        {
            _sprintServiceCrud = sprintServiceCrud;
        }

        // GET: Sprint
        public IActionResult Index()
        {
            return View("Views/Sprint/Index.cshtml", _sprintServiceCrud.List());
        }

        // GET: Sprint/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            return View(Mapper.Map<SprintViewModel>(_sprintServiceCrud.Get(id)));
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
                _sprintServiceCrud.Create(sprintViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(sprintViewModel);
        }

        // GET: Sprint/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
            return View(Mapper.Map<SprintViewModel>(_sprintServiceCrud.Get(id)));
        }

        // POST: Sprint/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,StartDate,Reward,IsActive")] SprintViewModel sprintViewModel)
        {
            if (id != sprintViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _sprintServiceCrud.Edit(sprintViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(sprintViewModel);
        }

        // GET: Sprint/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            return View(Mapper.Map<SprintViewModel>(_sprintServiceCrud.Get(id)));
        }

        // POST: Sprint/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _sprintServiceCrud.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
