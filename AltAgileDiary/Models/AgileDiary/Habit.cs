using System;

namespace AltAgileDiary.Models.AgileDiary
{
    public class Habit
    {
        public Guid Id { get; set; }
        public int MaxChainLength { get; set; }
        public int Total { get; set; }

        public Sprint Sprint { get; set; }
    }
}