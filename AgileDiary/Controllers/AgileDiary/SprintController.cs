using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Interfaces;
using AgileDiary.Models;
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

        public IActionResult Index()
        {
            //var sprints = new List<Guid>
            //{
            //    Guid.NewGuid()
            //};
            var model = new SprintViewModel
            {
                Sprints = sprintService.ListAll()
            };
            return View(model);
        }

        //public Task<IActionResult> AddItem(Sprint newSprint)
        public IActionResult CreateSprint()
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //var succesfull = sprintService.Create(newSprint);
            sprintService.Create();
            //if (!succesfull)
            //{
            //    return BadRequest(new
            //    {
            //        error = "Could not add item"
            //    });
            //}
            return Ok();
        }
    }
}