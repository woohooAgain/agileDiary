using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class Day
    {
        /// <summary>
        /// Date of the day
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Goals for the day
        /// </summary>
        public List<Guid> Goals { get; set; }

        /// <summary>
        /// Day result for each habbit
        /// </summary>
        public List<Guid> Habbits { get; set; }

        public Guid Id { get; set; }

        /// <summary>
        /// Result of the day
        /// </summary>
        public Guid Result { get; set; }

        /// <summary>
        /// Tasks for the day
        /// </summary>
        public List<Guid> Tasks { get; set; }
    }
}
