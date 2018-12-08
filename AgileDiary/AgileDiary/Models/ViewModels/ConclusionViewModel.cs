using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileDiary.Models.ViewModels
{
    public class ConclusionViewModel
    {
        public Guid Id { get; set; }
        public string Achievment { get; set; }
        public string Thanks { get; set; }
        public string Lesson { get; set; }
        public string Improvement { get; set; }
        public ConclusionType Type { get; set; }
    }

    public enum ConclusionType { Undefined, Sprint, Week }
}
