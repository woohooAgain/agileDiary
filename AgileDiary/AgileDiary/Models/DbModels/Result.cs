using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class Result
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Achievment { get; set; }
        public string Gratitude { get; set; }
        public string Lesson { get; set; }
        public string Improvement { get; set; }

        public virtual Sprint Sprint { get; set; }
        public virtual Week Week { get; set; }
        public virtual Day Day { get; set; }
    }
}
