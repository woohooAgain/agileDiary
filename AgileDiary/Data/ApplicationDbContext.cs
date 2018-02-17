using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Models;
using AgileDiary.Models.AgileDiary.DbModel;

namespace AgileDiary.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Day> Days { get; set; }
        public DbSet<DayResult> DayResults { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalResult> GoalResults { get; set; }
        public DbSet<Habbit> Habbits { get; set; }
        public DbSet<HabbitDayResult> HabbitDayResults { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ResultDescription> ResultDescriptions { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Models.AgileDiary.DbModel.Task> Tasks { get; set; }
        public DbSet<Week> Weeks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
