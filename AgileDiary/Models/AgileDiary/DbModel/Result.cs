using System;
using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.DbModel
{
    public class Result
    {
        /// <summary>
        /// Result of single Goal
        /// </summary>
        public Guid GoalResult { get; set; }

        /// <summary>
        /// ID of result
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Reference to common fields of result
        /// </summary>
        public Guid ResultDescription { get; set; }
    }
}
