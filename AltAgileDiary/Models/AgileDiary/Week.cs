using System;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Week
    {
        public Guid Id { get; set; }
        public string Conclusion { get; set; }
        public string Thanks { get; set; }

        public Sprint Sprint { get; set; }
    }
}