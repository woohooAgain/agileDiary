using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileDiary.Models.ViewModels;
using AgileDiary.Models;

namespace AgileDiary.Helpers.Mappers
{
    public static class TopPriorityMapper
    {
        public static TopPriorityViewModel Map(this TopPriority topPriority)
        {
            return new TopPriorityViewModel
            {
                Id = topPriority.TopPriorityId,
                Description = topPriority.Description
            };
        }

        public static TopPriority Map(this TopPriorityViewModel topPriority)
        {
            return new TopPriority
            {
                TopPriorityId = topPriority.Id,
                Description = topPriority.Description
            };
        }
    }
}
