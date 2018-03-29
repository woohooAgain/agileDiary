using System;
using System.Collections.Generic;
using System.Linq;
using AgileDiary.Interfaces;
using AgileDiary.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace AgileDiary.Services.AgileDiary
{
    public class GoalService : ICrud<Goal>
    {
        private readonly AgileDiaryDBContext _context;

        private readonly ICrud<Sprint> _sprintService;

        public GoalService(AgileDiaryDBContext context, ICrud<Sprint> sprintService)
        {
            _sprintService = sprintService;
            _context = context;
        }
        public IEnumerable<Guid> ListAll()
        {
            return _context.Goal.Select(s => s.Id);
        }

        public Goal Get(Guid id)
        {
            return _context.Goal.FirstOrDefault(s => s.Id == id);
        }

        public Guid Create()
        {
            throw new NotImplementedException();
        }

        public Guid Create(Guid sprintId)
        {
            var newGoal = new Goal
            {
                Id = Guid.NewGuid(),
                Sprint = sprintId
            };
            _context.Goal.Add(newGoal);
            var testSprint = _context.Sprint.FirstOrDefault(s => s.Id == sprintId);
            testSprint?.Goal.Add(newGoal);
            var entry = _context.Entry(testSprint);
            var changes = entry.Navigations.Where(n => n.IsModified).ToList();
            //entry.Property(e => e.Goal).IsModified = true;
            _context.SaveChanges();
            return newGoal.Id;
        }

        public Guid Edit(Goal obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
