using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AgileDiary.Models.DB
{
    public partial class AgileDiaryDBContext : DbContext
    {
        public virtual DbSet<Day> Day { get; set; }
        public virtual DbSet<DayResult> DayResult { get; set; }
        public virtual DbSet<Goal> Goal { get; set; }
        public virtual DbSet<GoalResult> GoalResult { get; set; }
        public virtual DbSet<Habbit> Habbit { get; set; }
        public virtual DbSet<HabbitDayResult> HabbitDayResult { get; set; }
        public virtual DbSet<Milestone> Milestone { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<ResultDescription> ResultDescription { get; set; }
        public virtual DbSet<Sprint> Sprint { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Week> Week { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=AgileDiaryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.GoalNavigation)
                    .WithMany(p => p.Day)
                    .HasForeignKey(d => d.Goal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_ToGoal");

                entity.HasOne(d => d.HabbitNavigation)
                    .WithMany(p => p.Day)
                    .HasForeignKey(d => d.Habbit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_ToHabbit");

                entity.HasOne(d => d.ResultNavigation)
                    .WithMany(p => p.Day)
                    .HasForeignKey(d => d.Result)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_ToResult");

                entity.HasOne(d => d.TaskNavigation)
                    .WithMany(p => p.Day)
                    .HasForeignKey(d => d.Task)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Day_ToTask");
            });

            modelBuilder.Entity<DayResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExerciseTime)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mood).HasDefaultValueSql("((0))");

                entity.Property(e => e.SleepTime)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WaterGlases).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.HabbitResultNavigation)
                    .WithMany(p => p.DayResult)
                    .HasForeignKey(d => d.HabbitResult)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DayResult_ToHabbitDayResult");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Reason).HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.MilestoneNavigation)
                    .WithMany(p => p.Goal)
                    .HasForeignKey(d => d.Milestone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_ToMilestone");
            });

            modelBuilder.Entity<GoalResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Habbit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<HabbitDayResult>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.HabbitNavigation)
                    .WithMany(p => p.HabbitDayResult)
                    .HasForeignKey(d => d.Habbit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HabbitDayResult_ToHabbit");
            });

            modelBuilder.Entity<Milestone>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.GoalResultNavigation)
                    .WithMany(p => p.ResultNavigation)
                    .HasForeignKey(d => d.GoalResult)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_ToGoalResult");

                entity.HasOne(d => d.ResultDescriptionNavigation)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.ResultDescription)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Result_ToResultDescription");
            });

            modelBuilder.Entity<ResultDescription>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Achievment)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Lesson)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PossibleImprovements)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Thanks)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Sprint>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndTime).HasColumnType("date");

                entity.Property(e => e.Reward)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.GoalNavigation)
                    .WithMany(p => p.Sprint)
                    .HasForeignKey(d => d.Goal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sprint_ToGoal");

                entity.HasOne(d => d.HabbitNavigation)
                    .WithMany(p => p.Sprint)
                    .HasForeignKey(d => d.Habbit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sprint_ToHabbit");

                entity.HasOne(d => d.ResultNavigation)
                    .WithMany(p => p.Sprint)
                    .HasForeignKey(d => d.Result)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sprint_ToResult");

                entity.HasOne(d => d.WeekNavigation)
                    .WithMany(p => p.Sprint)
                    .HasForeignKey(d => d.Week)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sprint_ToWeek");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Week>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DayNavigation)
                    .WithMany(p => p.Week)
                    .HasForeignKey(d => d.Day)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Week_ToDay");

                entity.HasOne(d => d.GoalNavigation)
                    .WithMany(p => p.Week)
                    .HasForeignKey(d => d.Goal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Week_ToGoal");

                entity.HasOne(d => d.ResultNavigation)
                    .WithMany(p => p.Week)
                    .HasForeignKey(d => d.Result)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Week_ToResult");
            });
        }
    }
}
