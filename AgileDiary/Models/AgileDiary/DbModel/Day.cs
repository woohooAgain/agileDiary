using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiary.DbModel
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
        public Guid Goal { get; set; }

        /// <summary>
        /// Day result for each habbit
        /// </summary>
        public Guid Habbit { get; set; }

        public Guid Id { get; set; }

        /// <summary>
        /// Result of the day
        /// </summary>
        public Guid Result { get; set; }

        /// <summary>
        /// Tasks for the day
        /// </summary>
        public Guid Task { get; set; }
    }
}
