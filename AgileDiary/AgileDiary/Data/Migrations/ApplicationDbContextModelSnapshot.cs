﻿// <auto-generated />
using System;
using AgileDiary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgileDiary.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgileDiary.Models.Day", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("WeekId");

                    b.ToTable("Day");
                });

            modelBuilder.Entity("AgileDiary.Models.Goal", b =>
                {
                    b.Property<Guid>("GoalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Result");

                    b.Property<Guid>("SprintId");

                    b.Property<string>("Title");

                    b.HasKey("GoalId");

                    b.HasIndex("SprintId");

                    b.ToTable("Goal");
                });

            modelBuilder.Entity("AgileDiary.Models.Habit", b =>
                {
                    b.Property<Guid>("HabitId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("SprintId");

                    b.HasKey("HabitId");

                    b.HasIndex("SprintId");

                    b.ToTable("Habit");
                });

            modelBuilder.Entity("AgileDiary.Models.Milestone", b =>
                {
                    b.Property<Guid>("MilestoneId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("GoalId");

                    b.HasKey("MilestoneId");

                    b.HasIndex("GoalId");

                    b.ToTable("Milestone");
                });

            modelBuilder.Entity("AgileDiary.Models.Sprint", b =>
                {
                    b.Property<Guid>("SprintId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Creator");

                    b.Property<string>("Reward");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("SprintId");

                    b.ToTable("Sprint");
                });

            modelBuilder.Entity("AgileDiary.Models.SprintConclusion", b =>
                {
                    b.Property<Guid>("SprintConclusionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievment");

                    b.Property<string>("Improvement");

                    b.Property<string>("Lesson");

                    b.Property<Guid>("SprintId");

                    b.Property<string>("Thanks");

                    b.HasKey("SprintConclusionId");

                    b.HasIndex("SprintId")
                        .IsUnique();

                    b.ToTable("SprintConclusion");
                });

            modelBuilder.Entity("AgileDiary.Models.TopPriority", b =>
                {
                    b.Property<Guid>("TopPriorityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("WeekId");

                    b.HasKey("TopPriorityId");

                    b.HasIndex("WeekId");

                    b.ToTable("TopPriority");
                });

            modelBuilder.Entity("AgileDiary.Models.Week", b =>
                {
                    b.Property<Guid>("WeekId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("SprintId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("WeekId");

                    b.HasIndex("SprintId");

                    b.ToTable("Week");
                });

            modelBuilder.Entity("AgileDiary.Models.WeekConclusion", b =>
                {
                    b.Property<Guid>("WeekConclusionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievment");

                    b.Property<string>("Improvement");

                    b.Property<string>("Lesson");

                    b.Property<string>("Thanks");

                    b.Property<Guid>("WeekId");

                    b.HasKey("WeekConclusionId");

                    b.HasIndex("WeekId")
                        .IsUnique();

                    b.ToTable("WeekConclusion");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AgileDiary.Models.Day", b =>
                {
                    b.HasOne("AgileDiary.Models.Week")
                        .WithMany("Days")
                        .HasForeignKey("WeekId");
                });

            modelBuilder.Entity("AgileDiary.Models.Goal", b =>
                {
                    b.HasOne("AgileDiary.Models.Sprint", "Sprint")
                        .WithMany("Goals")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgileDiary.Models.Habit", b =>
                {
                    b.HasOne("AgileDiary.Models.Sprint", "Sprint")
                        .WithMany("Habits")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgileDiary.Models.Milestone", b =>
                {
                    b.HasOne("AgileDiary.Models.Goal", "Goal")
                        .WithMany("Milestones")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgileDiary.Models.SprintConclusion", b =>
                {
                    b.HasOne("AgileDiary.Models.Sprint", "Sprint")
                        .WithOne("SprintConclusion")
                        .HasForeignKey("AgileDiary.Models.SprintConclusion", "SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgileDiary.Models.TopPriority", b =>
                {
                    b.HasOne("AgileDiary.Models.Week", "Week")
                        .WithMany("TopPriorities")
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgileDiary.Models.Week", b =>
                {
                    b.HasOne("AgileDiary.Models.Sprint", "Sprint")
                        .WithMany("Weeks")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgileDiary.Models.WeekConclusion", b =>
                {
                    b.HasOne("AgileDiary.Models.Week", "Week")
                        .WithOne("WeekConclusion")
                        .HasForeignKey("AgileDiary.Models.WeekConclusion", "WeekId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
