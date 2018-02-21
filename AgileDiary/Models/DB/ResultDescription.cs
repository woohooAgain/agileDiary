using System;
using System.Collections.Generic;

namespace AgileDiary.Models.DB
{
    public partial class ResultDescription
    {
        public ResultDescription()
        {
            Result = new HashSet<Result>();
        }

        public Guid Id { get; set; }
        public string Achievment { get; set; }
        public string Thanks { get; set; }
        public string PossibleImprovements { get; set; }
        public string Lesson { get; set; }

        public ICollection<Result> Result { get; set; }
    }
}
