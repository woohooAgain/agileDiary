using System;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Week
    {
        public Week(DateTime start)
        {
            Start = start;
            End = Start + TimeSpan.FromDays(7);
        }

        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }
        public DateTime Start { get; }
        public DateTime End { get; }

        public Sprint Sprint { get; set; }
    }
}