using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileDiary.Models.AgileDiaryDBModels
{
    public class ResultDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Achievment { get; set; }
        public string Gratitude { get; set; }
        public string Lesson { get; set; }
        public string Improvement { get; set; }
    }
}
