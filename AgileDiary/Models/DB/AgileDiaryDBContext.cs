using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AgileDiary.Models.Db
{
    public partial class AgileDiaryDBContext : DbContext
    {
        public virtual DbSet<Day> Day { get; set; }
        public virtual DbSet<Goal> Goal { get; set; }
        public virtual DbSet<Habbit> Habbit { get; set; }
        public virtual DbSet<HabbitDayResult> HabbitDayResult { get; set; }
        public virtual DbSet<Milestone> Milestone { get; set; }
        public virtual DbSet<Sprint> Sprint { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskForDay> TaskForDay { get; set; }
        public virtual DbSet<TaskForWeek> TaskForWeek { get; set; }
        public virtual DbSet<Week> Week { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=agilediarydb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Achievements).HasColumnType("text");

                entity.Property(e => e.Thanks).HasColumnType("text");

                entity.HasOne(d => d.WeekNavigation)
                    .WithMany(p => p.Day)
                    .HasForeignKey(d => d.Week)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_Week");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.Result).HasColumnType("text");

                entity.HasOne(d => d.SprintNavigation)
                    .WithMany(p => p.Goal)
                    .HasForeignKey(d => d.Sprint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_Sprint");
            });

            modelBuilder.Entity<Habbit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.SprintNavigation)
                    .WithMany(p => p.Habbit)
                    .HasForeignKey(d => d.Sprint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Habbit_Sprint");
            });

            modelBuilder.Entity<HabbitDayResult>(entity =>
            {
                entity.HasKey(e => new { e.Habbit, e.Day });

                entity.HasOne(d => d.DayNavigation)
                    .WithMany(p => p.HabbitDayResult)
                    .HasForeignKey(d => d.Day)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HabbitDayResult_Day");

                entity.HasOne(d => d.HabbitNavigation)
                    .WithMany(p => p.HabbitDayResult)
                    .HasForeignKey(d => d.Habbit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HabbitDayResult_Habbit");
            });

            modelBuilder.Entity<Milestone>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.HasOne(d => d.GoalNavigation)
                    .WithMany(p => p.Milestone)
                    .HasForeignKey(d => d.Goal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Milestone_Goal");
            });

            modelBuilder.Entity<Sprint>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Conclusion).HasColumnType("text");

                entity.Property(e => e.Improvements).HasColumnType("text");

                entity.Property(e => e.Reward).HasColumnType("text");

                entity.Property(e => e.Thanks).HasColumnType("text");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Result).HasColumnType("text");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaskForDay>(entity =>
            {
                entity.HasKey(e => new { e.Task, e.Day });

                entity.HasOne(d => d.DayNavigation)
                    .WithMany(p => p.TaskForDay)
                    .HasForeignKey(d => d.Day)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskForDay_Day");

                entity.HasOne(d => d.TaskNavigation)
                    .WithMany(p => p.TaskForDay)
                    .HasForeignKey(d => d.Task)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskForDay_Task");
            });

            modelBuilder.Entity<TaskForWeek>(entity =>
            {
                entity.HasKey(e => new { e.Task, e.Week });

                entity.HasOne(d => d.TaskNavigation)
                    .WithMany(p => p.TaskForWeek)
                    .HasForeignKey(d => d.Task)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskForWeek_Task");

                entity.HasOne(d => d.WeekNavigation)
                    .WithMany(p => p.TaskForWeek)
                    .HasForeignKey(d => d.Week)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskForWeek_Week");
            });

            modelBuilder.Entity<Week>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Conclusion).HasColumnType("text");

                entity.Property(e => e.Thanks).HasColumnType("text");

                entity.HasOne(d => d.SprintNavigation)
                    .WithMany(p => p.Week)
                    .HasForeignKey(d => d.Sprint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Week_Sprint");
            });
        }
    }
}
