using System;

namespace AgileDiary.Models.AgileDiary.UsualModels
{
    public class DayResult : ResultDescription
    {
        /// <summary>
        /// Time for phisycal execercises
        /// </summary>
        public TimeSpan ExerciseTime { get; set; }

        public Guid Id { get; set; }

        /// <summary>
        /// Your mood during the day
        /// </summary>
        public Mood Mood { get; set; }

        /// <summary>
        /// How much did you sleep lst night
        /// </summary>
        public TimeSpan SleepTime { get; set; }

        /// <summary>
        /// Number of water glases during day
        /// </summary>
        public int WaterGlases { get; set; }
    }

    public enum Mood
    {
        VeryBad,
        Bad,
        Average,
        Good,
        Escellent
    }
}
