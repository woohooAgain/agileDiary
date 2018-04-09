using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AltAgileDiary.Models;
using AltAgileDiary.Models.AgileDiary;

namespace AltAgileDiary.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Sprint> Sprints { get; set; }

        public DbSet<Goal> Goal { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Sprint>().ToTable("Sprint");
        }

        public DbSet<Habit> Habit { get; set; }

        public DbSet<Week> Weeks { get; set; }
    }
}
