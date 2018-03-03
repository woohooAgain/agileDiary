using System;
using System.Collections.Generic;
using System.Linq;
using AgileDiary.Interfaces;
using AgileDiary.Models.Db;

namespace AgileDiary.Services.AgileDiary
{
    public class SprintService : ICrud<Sprint>
    {
        private readonly AgileDiaryDBContext _context;

        public SprintService(AgileDiaryDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Guid> ListAll()
        {
            return _context.Sprint.Select(s => s.Id);
        }
          
        public Sprint Get(Guid id)
        {
            return _context.Sprint.FirstOrDefault(s => s.Id == id);
        }

        public Guid Create()
        {
            var newSprint = new Sprint
            {
                Id = Guid.NewGuid()
            };
            _context.Sprint.Add(newSprint);
            _context.SaveChanges();
            return newSprint.Id;
        }

        public Guid Edit(Sprint obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
