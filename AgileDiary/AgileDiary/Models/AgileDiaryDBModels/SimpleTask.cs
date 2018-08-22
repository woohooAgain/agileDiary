using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class SimpleTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Finished { get; set; }

        public virtual Day Day { get; set; }
        public virtual Week Week { get; set; }
        public virtual Goal Goal { get; set; }
    }
}
