using AgileDiary.Models.ViewModels;
using AgileDiary.Models;
using System;

namespace AgileDiary.Helpers.Mappers
{
    public static class ConclusionMapper
    {
        public static ConclusionViewModel Map(this SprintConclusion sprintConclusion)
        {
            return new ConclusionViewModel
            {
                Id = sprintConclusion.SprintConclusionId,
                Achievment = sprintConclusion.Achievment,
                Improvement = sprintConclusion.Improvement,
                Lesson = sprintConclusion.Lesson,
                Thanks = sprintConclusion.Thanks,
                Type = ConclusionType.Sprint
            };
        }

        public static ConclusionViewModel Map(this WeekConclusion sprintConclusion)
        {
            return new ConclusionViewModel
            {
                Id = sprintConclusion.WeekConclusionId,
                Achievment = sprintConclusion.Achievment,
                Improvement = sprintConclusion.Improvement,
                Lesson = sprintConclusion.Lesson,
                Thanks = sprintConclusion.Thanks,
                Type = ConclusionType.Week
            };
        }

        public static object Map(this ConclusionViewModel conclusion)
        {
            switch (conclusion.Type)
            {
                case ConclusionType.Sprint:
                    return new SprintConclusion
                    {
                        SprintConclusionId = conclusion.Id,
                        Achievment = conclusion.Achievment,
                        Improvement = conclusion.Improvement,
                        Lesson = conclusion.Lesson,
                        Thanks = conclusion.Thanks
                    };
                case ConclusionType.Week:
                    return new WeekConclusion
                    {
                        WeekConclusionId = conclusion.Id,
                        Achievment = conclusion.Achievment,
                        Improvement = conclusion.Improvement,
                        Lesson = conclusion.Lesson,
                        Thanks = conclusion.Thanks
                    };
                default:
                    throw new ArgumentOutOfRangeException(conclusion.Type.ToString());
            }
        }
    }
}
