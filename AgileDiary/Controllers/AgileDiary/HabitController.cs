using System;
using AgileDiary.Interfaces;
using AgileDiary.Models.Db;
using Microsoft.AspNetCore.Mvc;

namespace AgileDiary.Controllers.AgileDiary
{
    public class HabitController : Controller
    {
        private readonly ICrud<Habbit> _habitServcie;

        public HabitController(ICrud<Habbit> habitService)
        {
            _habitServcie = habitService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetHabit(Guid id)
        {
            var goal = _habitServcie.Get(id);
            return View();
        }
    }
}