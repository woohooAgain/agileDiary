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

        public IActionResult ConcreteGoal(Guid id)
        {
            var goal = _goalService.Get(id);
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

        public IActionResult CreateGoal()
        {
            var newGoalId = _goalService.Create();
            var model = new ConcreteGoalViewModel
            {
                Id = newGoalId
            };
            return View("ConcreteGoal", model);
        }
    }
}