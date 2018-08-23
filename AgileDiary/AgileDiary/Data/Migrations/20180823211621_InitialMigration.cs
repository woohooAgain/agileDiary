using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Achievment = table.Column<string>(nullable: true),
                    Gratitude = table.Column<string>(nullable: true),
                    Lesson = table.Column<string>(nullable: true),
                    Improvement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Reward = table.Column<string>(nullable: true),
                    SprintResultId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprints_Results_SprintResultId",
                        column: x => x.SprintResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    SprintId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    SprintId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habits_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    WeekResultId = table.Column<Guid>(nullable: true),
                    SprintId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weeks_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Results_WeekResultId",
                        column: x => x.WeekResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    WeekId = table.Column<Guid>(nullable: true),
                    DayResultId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Results_DayResultId",
                        column: x => x.DayResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Days_Weeks_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    WeekId = table.Column<Guid>(nullable: true),
                    GoalId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Milestones_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Milestones_Weeks_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HabitResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Done = table.Column<bool>(nullable: false),
                    HabitId = table.Column<Guid>(nullable: true),
                    DayId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitResults_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HabitResults_Habits_HabitId",
                        column: x => x.HabitId,
                        principalTable: "Habits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SimpleTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Finished = table.Column<bool>(nullable: false),
                    DayId = table.Column<Guid>(nullable: true),
                    WeekId = table.Column<Guid>(nullable: true),
                    GoalId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleTasks_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SimpleTasks_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SimpleTasks_Weeks_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Days_DayResultId",
                table: "Days",
                column: "DayResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_WeekId",
                table: "Days",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_SprintId",
                table: "Goals",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitResults_DayId",
                table: "HabitResults",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitResults_HabitId",
                table: "HabitResults",
                column: "HabitId");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_SprintId",
                table: "Habits",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_GoalId",
                table: "Milestones",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_WeekId",
                table: "Milestones",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleTasks_DayId",
                table: "SimpleTasks",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleTasks_GoalId",
                table: "SimpleTasks",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleTasks_WeekId",
                table: "SimpleTasks",
                column: "WeekId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_SprintResultId",
                table: "Sprints",
                column: "SprintResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_SprintId",
                table: "Weeks",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_WeekResultId",
                table: "Weeks",
                column: "WeekResultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabitResults");

            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DropTable(
                name: "SimpleTasks");

            migrationBuilder.DropTable(
                name: "Habits");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
