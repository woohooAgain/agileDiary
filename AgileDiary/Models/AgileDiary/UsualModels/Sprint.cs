using System;
using System.Collections.Generic;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class Sprint
    {
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Guid> Goals { get; set; }

        public List<Guid> Habbits { get; set; }

        public Guid Result { get; set; }

        public string Reward { get; set; }

        public List<Guid> Weeks { get; set; }
    }
}
