using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Day
    {
        public Guid Id { get; set; }
        public string Achievements { get; set; }
        public string Thanks { get; set; }
        public DateTime Date { get; set; }

        public Guid WeekId { get; set; }
        public Week Week { get; set; }
    }
}
