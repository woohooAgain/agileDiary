using System;
using System.Collections.Generic;

namespace AgileDiary.Interfaces
{
    public interface ICrud<T>
    {
        IEnumerable<Guid> ListAll();
        T Get(Guid id);
        Guid Create(T obj);
        Guid Edit(T obj);
        void Delete(Guid id);
    }
}
