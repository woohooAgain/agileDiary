using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Interfaces;
using AgileDiary.Models;
using AgileDiary.Models.AgileDiaryViewModels;
using AgileDiary.Models.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.OData.Query.SemanticAst;

namespace AgileDiary.Controllers.AgileDiary
{
    public class SprintController : Controller
    {
        private readonly ICrud<Sprint> sprintService;
        public SprintController(ICrud<Sprint> sprintService)
        {
            this.sprintService = sprintService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new AllSprintsViewModel
            {
                Sprints = sprintService.ListAll()
            };
            return View(model);
        }

        [HttpGet]
        [Route("Sprint/{id}")]
        public IActionResult ConcreteSprint(Guid id)
        {
            var sprint = sprintService.Get(id);
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
            sprintService.Create();
            return Ok();
        }
    }
}