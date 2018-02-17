using System;
using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class Result
    {
        /// <summary>
        /// Result of single Goal
        /// </summary>
        public List<Guid> GoalResults { get; set; }

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
