using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.ViewModels
{
    public class DayViewModel
    {
        //public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<TaskViewModel> Tasks { get; set; }
    }
}
