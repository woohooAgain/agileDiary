using System;
using System.Collections.Generic;

namespace AgileDiary.Interfaces
{
    public interface ICrud<T>
    {
        IEnumerable<Guid> ListAll();
        T Get(Guid id);
        Guid Create(Guid sprintId);
        Guid Create();
        Guid Edit(T obj);
        void Delete(Guid id);
    }
}
