using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Interfaces;
using AgileDiary.Models.Db;

namespace AgileDiary.Services.AgileDiary
{
    public class SprintService : ICrud<Sprint>
    {
        public IEnumerable<Guid> ListAll()
        {
            throw new NotImplementedException();
        }

        public Sprint Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Create(Sprint obj)
        {
            throw new NotImplementedException();
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
