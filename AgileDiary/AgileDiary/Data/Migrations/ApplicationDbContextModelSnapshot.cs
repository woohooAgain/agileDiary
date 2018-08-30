﻿// <auto-generated />
using System;
using AgileDiary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgileDiary.Data.Migrations
{
    [DbContext(typeof(AgileDiaryDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.DayDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid?>("DayResultId");

                    b.Property<Guid?>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("DayResultId");

                    b.HasIndex("WeekId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.GoalDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area");

                    b.Property<string>("Description");

                    b.Property<string>("Reason");

                    b.Property<Guid?>("SprintId");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.HabitDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("SprintId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.ToTable("Habits");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.HabitResultDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("DayId");

                    b.Property<bool>("Done");

                    b.Property<Guid?>("HabitId");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("HabitId");

                    b.ToTable("HabitResults");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.MilestoneDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("GoalDbModelId");

                    b.Property<string>("Title");

                    b.Property<Guid?>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("GoalDbModelId");

                    b.HasIndex("WeekId");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.ResultDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievment");

                    b.Property<string>("Gratitude");

                    b.Property<string>("Improvement");

                    b.Property<string>("Lesson");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.SimpleTaskDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<Guid?>("DayId");

                    b.Property<bool>("Finished");

                    b.Property<Guid?>("GoalId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<Guid?>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("GoalId");

                    b.HasIndex("WeekId");

                    b.ToTable("SimpleTasks");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.SprintDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Reward");

                    b.Property<Guid?>("SprintResultId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("SprintResultId");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.WeekDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("SprintId");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid?>("WeekResultId");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.HasIndex("WeekResultId");

                    b.ToTable("Weeks");
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

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.DayDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.ResultDbModel", "DayResult")
                        .WithMany()
                        .HasForeignKey("DayResultId");

                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.WeekDbModel", "Week")
                        .WithMany("Days")
                        .HasForeignKey("WeekId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.GoalDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.SprintDbModel", "Sprint")
                        .WithMany("Goals")
                        .HasForeignKey("SprintId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.HabitDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.SprintDbModel", "Sprint")
                        .WithMany("Habits")
                        .HasForeignKey("SprintId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.HabitResultDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.DayDbModel", "Day")
                        .WithMany("HabitResults")
                        .HasForeignKey("DayId");

                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.HabitDbModel", "Habit")
                        .WithMany("HabitResults")
                        .HasForeignKey("HabitId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.MilestoneDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.GoalDbModel")
                        .WithMany("Milestones")
                        .HasForeignKey("GoalDbModelId");

                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.WeekDbModel", "Week")
                        .WithMany()
                        .HasForeignKey("WeekId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.SimpleTaskDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.DayDbModel", "Day")
                        .WithMany("Tasks")
                        .HasForeignKey("DayId");

                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.GoalDbModel", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalId");

                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.WeekDbModel", "Week")
                        .WithMany("Tasks")
                        .HasForeignKey("WeekId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.SprintDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.ResultDbModel", "SprintResult")
                        .WithMany()
                        .HasForeignKey("SprintResultId");
                });

            modelBuilder.Entity("AgileDiary.Models.AgileDiaryDBModels.WeekDbModel", b =>
                {
                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.SprintDbModel", "Sprint")
                        .WithMany("Weeks")
                        .HasForeignKey("SprintId");

                    b.HasOne("AgileDiary.Models.AgileDiaryDBModels.ResultDbModel", "WeekResult")
                        .WithMany()
                        .HasForeignKey("WeekResultId");
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
