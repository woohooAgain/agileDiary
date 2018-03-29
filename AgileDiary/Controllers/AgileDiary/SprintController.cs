using System;
using AgileDiary.Interfaces;
using AgileDiary.Models.AgileDiaryViewModels;
using AgileDiary.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace AgileDiary.Controllers.AgileDiary
{
    public class SprintController : Controller
    {
        private readonly ICrud<Sprint> _sprintService;
        public SprintController(ICrud<Sprint> sprintService)
        {
            this._sprintService = sprintService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new AllSprintsViewModel
            {
                Sprints = _sprintService.ListAll()
            };
            return View(model);
        }

        [HttpGet]
        [Route("Sprint/{id}")]
        public IActionResult ConcreteSprint(Guid id)
        {
            var sprint = _sprintService.Get(id);
            var model = new ConcreteSprintViewModel
            {
                Id = sprint.Id,
                Conclusion = sprint.Conclusion,
                Goal = sprint.Goal,
                Habbit = sprint.Habbit,
                Improvements = sprint.Improvements,
                Reward = sprint.Reward,
                Thanks = sprint.Thanks,
                Week = sprint.Week
            };
            return View(model);
        }

        public IActionResult CreateSprint()
        {
            var newSprintId = _sprintService.Create();
            return Ok(newSprintId);
        }

        [Route("Sprint/Delete/{id}")]
        public IActionResult Delete(Guid id)
        {
            _sprintService.Delete(id);
            var model = new AllSprintsViewModel
            {
                Sprints = _sprintService.ListAll()
            };
            return View("Index", model);
        }
    }
}