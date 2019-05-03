using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.ViewModels
{
    public class WeekViewModel
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ConclusionViewModel Conclusion { get; set; }
        public List<TopPriorityViewModel> TopPriorities { get; set; }
        public List<DayViewModel> Days { get; set; }

        public Guid SprintId { get; set; }
    }
}
