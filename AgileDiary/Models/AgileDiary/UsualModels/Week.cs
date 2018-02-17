using System;
using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class Week
    {
        /// <summary>
        /// Days in the week
        /// </summary>
        public List<Guid> Days { get; set; }

        /// <summary>
        /// Goals for the week
        /// </summary>
        public List<Guid> Goals { get; set; }

        public Guid Id { get; set; }

        /// <summary>
        /// Result of the week
        /// </summary>
        public Guid Result { get; set; }
    }
}
