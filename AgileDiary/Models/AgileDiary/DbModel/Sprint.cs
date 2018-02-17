using System;
using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.DbModel
{
    public class Sprint
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Guid Goal { get; set; }

        public Guid Habbit { get; set; }

        public Guid Result { get; set; }

        public string Reward { get; set; }

        public Guid Week { get; set; }
    }
}
