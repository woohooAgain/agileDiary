using System;
using System.Collections.Generic;
using AgileDiary.Models.ViewModels;

namespace AgileDiary.Interfaces
{
    public interface ISprintServiceCrud
    {
        Guid Create(SprintViewModel sprint);
        Guid Edit(SprintViewModel sprint);
        SprintViewModel Get(Guid id);
        IEnumerable<SprintViewModel> List();
        void Delete(Guid id);
    }
}