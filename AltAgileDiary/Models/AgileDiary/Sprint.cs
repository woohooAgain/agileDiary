using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Sprint
    {
        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }
        public string Improvements { get; set; }
        public string Reward { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime End { get; set; }

        public ICollection<Goal> Goals { get; set; }
        public ICollection<Habit> Habits { get; set; }
        public ICollection<Week> Weeks { get; set; }
    }
}
