﻿// <auto-generated />
using AltAgileDiary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AltAgileDiary.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Day", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Achievements");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Thanks");

                    b.Property<Guid>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("WeekId");

                    b.ToTable("Day");
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Goal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Reason");

                    b.Property<string>("Result");

                    b.Property<Guid>("SprintId");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.ToTable("Goal");
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Habit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MaxChainLength");

                    b.Property<Guid>("SprintId");

                    b.Property<string>("Title");

                    b.Property<int>("Total");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.ToTable("Habit");
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Sprint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Conclusion");

                    b.Property<DateTime>("End");

                    b.Property<string>("Improvements");

                    b.Property<string>("Reward");

                    b.Property<DateTime>("Start");

                    b.Property<string>("Thanks");

                    b.HasKey("Id");

                    b.ToTable("Sprint");
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("DayId");

                    b.Property<string>("Description");

                    b.Property<bool>("Finished");

                    b.Property<Guid?>("GoalId");

                    b.Property<Guid>("WeekId");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("GoalId");

                    b.HasIndex("WeekId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Week", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Conclusion");

                    b.Property<DateTime>("End");

                    b.Property<Guid>("SprintId");

                    b.Property<DateTime>("Start");

                    b.Property<string>("Thanks");

                    b.HasKey("Id");

                    b.HasIndex("SprintId");

                    b.ToTable("Weeks");
                });

            modelBuilder.Entity("AltAgileDiary.Models.ApplicationUser", b =>
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Day", b =>
                {
                    b.HasOne("AltAgileDiary.Models.AgileDiary.Week", "Week")
                        .WithMany("Days")
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Goal", b =>
                {
                    b.HasOne("AltAgileDiary.Models.AgileDiary.Sprint", "Sprint")
                        .WithMany("Goals")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Habit", b =>
                {
                    b.HasOne("AltAgileDiary.Models.AgileDiary.Sprint", "Sprint")
                        .WithMany("Habits")
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Task", b =>
                {
                    b.HasOne("AltAgileDiary.Models.AgileDiary.Day", "Day")
                        .WithMany("Tasks")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AltAgileDiary.Models.AgileDiary.Goal", "Goal")
                        .WithMany("Tasks")
                        .HasForeignKey("GoalId");

                    b.HasOne("AltAgileDiary.Models.AgileDiary.Week", "Week")
                        .WithMany("Tasks")
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AltAgileDiary.Models.AgileDiary.Week", b =>
                {
                    b.HasOne("AltAgileDiary.Models.AgileDiary.Sprint", "Sprint")
                        .WithMany("Weeks")
                        .HasForeignKey("SprintId")
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
                    b.HasOne("AltAgileDiary.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AltAgileDiary.Models.ApplicationUser")
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

                    b.HasOne("AltAgileDiary.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AltAgileDiary.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
