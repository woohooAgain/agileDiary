using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class Sprint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public string Reward { get; set; }

        public virtual ICollection<Week> Weeks { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual Result SprintResult { get; set; }
        public virtual ICollection<Habit> Habits { get; set; }
    }
}
