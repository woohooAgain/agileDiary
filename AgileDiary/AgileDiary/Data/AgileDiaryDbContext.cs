using System;
using System.Collections.Generic;
using System.Text;
using AgileDiary.Models.AgileDiaryDBModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgileDiary.Data
{
    public class AgileDiaryDbContext : IdentityDbContext
    {
        public AgileDiaryDbContext(DbContextOptions<AgileDiaryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Day> Days { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Habit> Habits { get; set; }
        public DbSet<HabitResult> HabitResults { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<SimpleTask> SimpleTasks { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Week> Weeks { get; set; }
    }
}
