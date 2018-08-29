using System;
using System.Collections.Generic;
using System.Linq;
using AgileDiary.Interfaces;
using AgileDiary.Models.AgileDiaryDBModels;
using AgileDiary.Models.ViewModels;
using AutoMapper;

namespace AgileDiary.Services
{
    public class SprintService : ISprintServiceCrud
    {
        private readonly ISprintManagerCrud _manager;

        public SprintService(ISprintManagerCrud manager)
        {
            _manager = manager;
        }

        public Guid Create(SprintViewModel sprint)
        {
            sprint.Id = new Guid();
            _manager.Create(Mapper.Map<SprintDbModel>(sprint));
            return sprint.Id;
        }

        public Guid Edit(SprintViewModel sprint)
        {
            _manager.Edit(Mapper.Map<SprintDbModel>(sprint));
            return sprint.Id;
        }

        public SprintViewModel Get(Guid id)
        {
            return Mapper.Map<SprintViewModel>(_manager.Get(id));
        }

        public IEnumerable<SprintViewModel> List()
        {
            var dbSprints = _manager.List().ToList();
            return dbSprints.Select(Mapper.Map<SprintViewModel>);
        }

        public void Delete(Guid id)
        {
            _manager.Delete(id);
        }
    }
}
