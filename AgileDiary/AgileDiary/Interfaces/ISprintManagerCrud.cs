using System;
using System.Collections.Generic;
using AgileDiary.Models.AgileDiaryDBModels;

namespace AgileDiary.Interfaces
{
    public interface ISprintManagerCrud
    {
        void Create(SprintDbModel sprint);
        void Edit(SprintDbModel sprint);
        SprintDbModel Get(Guid id);
        ICollection<SprintDbModel> List();
        void Delete(Guid id);
    }
}