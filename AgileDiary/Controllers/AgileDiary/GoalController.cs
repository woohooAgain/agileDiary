using System;
using AgileDiary.Interfaces;
using AgileDiary.Models.AgileDiaryViewModels;
using AgileDiary.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace AgileDiary.Controllers.AgileDiary
{
    public class GoalController : Controller
    {
        private readonly ICrud<Goal> _goalService;
        public GoalController(ICrud<Goal> goalService)
        {
            _goalService = goalService;
        }

        [HttpGet]
        [Route("Goal")]
        public IActionResult Index()
        {
            var model = new AllGoalsViewModel
            {
                Goals = _goalService.ListAll()
            };
            return View("AllGoalsViewModel", model);
        }

        [HttpGet]
        [Route("Goal/{goalId}")]
        public IActionResult ConcreteGoal(Guid goalId)
        {
            var goal = _goalService.Get(goalId);
            var model = new ConcreteGoalViewModel
            {
                Id = goal.Id,
                Sprint = goal.Sprint,
                Description = goal.Description,
                Milestone = goal.Milestone,
                Result = goal.Result,
                Reason = goal.Reason,
                SprintNavigation = goal.SprintNavigation
            };
            return View(model);
        }

        [HttpPost]
        [Route("Goal/{sprintId}")]
        public IActionResult CreateGoal(Guid sprintId)
        {
            var newGoalId = _goalService.Create(sprintId);
            return Ok(newGoalId);
        }
    }
}