using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgileDiary.Models;

namespace AgileDiary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sprint> Sprint { get; set; }
        public DbSet<Week> Week { get; set; }
        public DbSet<Goal> Goal { get; set; }
        public DbSet<Task> Task { get; set; }
    }
}
