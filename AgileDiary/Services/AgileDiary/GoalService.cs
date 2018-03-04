using System;
using System.Collections.Generic;
using System.Linq;
using AgileDiary.Interfaces;
using AgileDiary.Models.Db;

namespace AgileDiary.Services.AgileDiary
{
    public class GoalService : ICrud<Goal>
    {
        private readonly AgileDiaryDBContext _context;

        public GoalService(AgileDiaryDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Guid> ListAll()
        {
            throw new NotImplementedException();
        }

        public Goal Get(Guid id)
        {
            return _context.Goal.FirstOrDefault(s => s.Id == id);
        }

        public Guid Create()
        {
            var newGoal = new Goal
            {
                Id = Guid.NewGuid()
            };
            _context.Goal.Add(newGoal);
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
