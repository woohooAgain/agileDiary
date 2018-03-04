using System;
using System.Collections.Generic;
using AgileDiary.Interfaces;
using AgileDiary.Models.Db;

namespace AgileDiary.Services.AgileDiary
{
    public class HabitService : ICrud<Habbit>
    {
        private readonly AgileDiaryDBContext _context;

        public HabitService(AgileDiaryDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Guid> ListAll()
        {
            throw new NotImplementedException();
        }

        public Habbit Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Create()
        {
            throw new NotImplementedException();
        }

        public Guid Edit(Habbit obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
