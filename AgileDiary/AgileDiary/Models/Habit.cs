using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models
{
    public class Habit
    {
        public Guid HabitId { get; set; }

        public Guid SprintId { get; set; }
        public Sprint Sprint { get; set; }
    }
}
