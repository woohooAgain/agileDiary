using System;
using System.Collections.Generic;
using System.Text;
using AgileDiary.Models.AgileDiaryDBModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Models.ViewModels;

namespace AgileDiary.Data
{
    public class AgileDiaryDbContext : IdentityDbContext
    {
        public AgileDiaryDbContext(DbContextOptions<AgileDiaryDbContext> options)
            : base(options)
        {
        }

        public DbSet<DayDbModel> Days { get; set; }
        public DbSet<GoalDbModel> Goals { get; set; }
        public DbSet<HabitDbModel> Habits { get; set; }
        public DbSet<HabitResultDbModel> HabitResults { get; set; }
        public DbSet<MilestoneDbModel> Milestones { get; set; }
        public DbSet<ResultDbModel> Results { get; set; }
        public DbSet<SimpleTaskDbModel> SimpleTasks { get; set; }
        public DbSet<SprintDbModel> Sprints { get; set; }
        public DbSet<WeekDbModel> Weeks { get; set; }
        public DbSet<AgileDiary.Models.ViewModels.SprintViewModel> SprintViewModel { get; set; }
    }
}
