using System;
using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.DbModel
{
    public class Week
    {
        /// <summary>
        /// Days in the week
        /// </summary>
        public Guid Day { get; set; }

        /// <summary>
        /// Goals for the week
        /// </summary>
        public Guid Goal { get; set; }

        public Guid Id { get; set; }

        /// <summary>
        /// Result of the week
        /// </summary>
        public Guid Result { get; set; }
    }
}
