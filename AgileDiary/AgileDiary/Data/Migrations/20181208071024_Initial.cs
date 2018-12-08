using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sprint",
                columns: table => new
                {
                    SprintId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Reward = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprint", x => x.SprintId);
                });

            migrationBuilder.CreateTable(
                name: "Goal",
                columns: table => new
                {
                    GoalId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    SprintId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goal", x => x.GoalId);
                    table.ForeignKey(
                        name: "FK_Goal_Sprint_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprint",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habit",
                columns: table => new
                {
                    HabitId = table.Column<Guid>(nullable: false),
                    SprintId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habit", x => x.HabitId);
                    table.ForeignKey(
                        name: "FK_Habit_Sprint_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprint",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SprintConclusion",
                columns: table => new
                {
                    SprintConclusionId = table.Column<Guid>(nullable: false),
                    Achievment = table.Column<string>(nullable: true),
                    Thanks = table.Column<string>(nullable: true),
                    Lesson = table.Column<string>(nullable: true),
                    Improvement = table.Column<string>(nullable: true),
                    SprintId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprintConclusion", x => x.SprintConclusionId);
                    table.ForeignKey(
                        name: "FK_SprintConclusion_Sprint_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprint",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Week",
                columns: table => new
                {
                    WeekId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    SprintId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Week", x => x.WeekId);
                    table.ForeignKey(
                        name: "FK_Week_Sprint_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprint",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Milestone",
                columns: table => new
                {
                    MilestoneId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    GoalId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestone", x => x.MilestoneId);
                    table.ForeignKey(
                        name: "FK_Milestone_Goal_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goal",
                        principalColumn: "GoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    WeekId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Day_Week_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Week",
                        principalColumn: "WeekId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TopPriority",
                columns: table => new
                {
                    TopPriorityId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    WeekId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopPriority", x => x.TopPriorityId);
                    table.ForeignKey(
                        name: "FK_TopPriority_Week_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Week",
                        principalColumn: "WeekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeekConclusion",
                columns: table => new
                {
                    WeekConclusionId = table.Column<Guid>(nullable: false),
                    Achievment = table.Column<string>(nullable: true),
                    Thanks = table.Column<string>(nullable: true),
                    Lesson = table.Column<string>(nullable: true),
                    Improvement = table.Column<string>(nullable: true),
                    WeekId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekConclusion", x => x.WeekConclusionId);
                    table.ForeignKey(
                        name: "FK_WeekConclusion_Week_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Week",
                        principalColumn: "WeekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Day_WeekId",
                table: "Day",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Goal_SprintId",
                table: "Goal",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Habit_SprintId",
                table: "Habit",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestone_GoalId",
                table: "Milestone",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_SprintConclusion_SprintId",
                table: "SprintConclusion",
                column: "SprintId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TopPriority_WeekId",
                table: "TopPriority",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Week_SprintId",
                table: "Week",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekConclusion_WeekId",
                table: "WeekConclusion",
                column: "WeekId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "Habit");

            migrationBuilder.DropTable(
                name: "Milestone");

            migrationBuilder.DropTable(
                name: "SprintConclusion");

            migrationBuilder.DropTable(
                name: "TopPriority");

            migrationBuilder.DropTable(
                name: "WeekConclusion");

            migrationBuilder.DropTable(
                name: "Goal");

            migrationBuilder.DropTable(
                name: "Week");

            migrationBuilder.DropTable(
                name: "Sprint");
        }
    }
}
