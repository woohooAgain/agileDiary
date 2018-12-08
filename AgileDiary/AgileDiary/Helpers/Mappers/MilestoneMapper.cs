using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Models.ViewModels;
using AgileDiary.Models;

namespace AgileDiary.Helpers.Mappers
{
    public static class MilestoneMapper
    {
        public static MilestoneViewModel Map(this Milestone milestone)
        {
            return new MilestoneViewModel
            {
                Id = milestone.MilestoneId,
                Description = milestone.Description
            };
        }

        public static Milestone Map(this MilestoneViewModel milestone)
        {
            return new Milestone
            {
                MilestoneId = milestone.Id,
                Description = milestone.Description
            };
        }
    }
}
