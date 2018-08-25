using System;
using System.Collections.Generic;
using System.Linq;
using AgileDiary.Data;
using AgileDiary.Interfaces;
using AgileDiary.Models.AgileDiaryDBModels;
using Microsoft.EntityFrameworkCore;

namespace AgileDiary.Managers
{
    public class SprintManager : ISprintCrud
    {
        private AgileDiaryDbContext _context;
        SprintManager(AgileDiaryDbContext context)
        {
            _context = context;
        }

        public void Create(SprintDbModel sprint)
        {
            _context.Sprints.Add(sprint);
            _context.SaveChanges();
        }

        public void Edit(SprintDbModel sprint)
        {
            _context.Sprints.Update(sprint);
            _context.SaveChanges();
        }

        public SprintDbModel Get(Guid id)
        {
            return _context.Sprints.Where(s => s.Id.Equals(id))
                .Include(s => s.Weeks)
                .Include(s => s.Goals)
                .Include(s => s.Habits)
                    .ThenInclude(h => h.HabitResults)
                .FirstOrDefault();
        }

        public ICollection<SprintDbModel> List()
        {
            return _context.Sprints.ToList();
        }

        public void Delete(Guid id)
        {
            _context.Sprints.Remove(Get(id));
            _context.SaveChanges();
        }
    }
}
