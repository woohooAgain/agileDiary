using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class InitialModels : Migration
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
                    SprintResultDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprints_Results_SprintResultDbModelId",
                        column: x => x.SprintResultDbModelId,
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
                    SprintDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goals_Sprints_SprintDbModelId",
                        column: x => x.SprintDbModelId,
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
                    SprintDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habits_Sprints_SprintDbModelId",
                        column: x => x.SprintDbModelId,
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
                    WeekResultDbModelId = table.Column<Guid>(nullable: true),
                    SprintDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weeks_Sprints_SprintDbModelId",
                        column: x => x.SprintDbModelId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Weeks_Results_WeekResultDbModelId",
                        column: x => x.WeekResultDbModelId,
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
                    WeekDbModelId = table.Column<Guid>(nullable: true),
                    DayResultDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Results_DayResultDbModelId",
                        column: x => x.DayResultDbModelId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Days_Weeks_WeekDbModelId",
                        column: x => x.WeekDbModelId,
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
                    WeekDbModelId = table.Column<Guid>(nullable: true),
                    GoalDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Milestones_Goals_GoalDbModelId",
                        column: x => x.GoalDbModelId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Milestones_Weeks_WeekDbModelId",
                        column: x => x.WeekDbModelId,
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
                    HabitDbModelId = table.Column<Guid>(nullable: true),
                    DayDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HabitResults_Days_DayDbModelId",
                        column: x => x.DayDbModelId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HabitResults_Habits_HabitDbModelId",
                        column: x => x.HabitDbModelId,
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
                    DayDbModelId = table.Column<Guid>(nullable: true),
                    WeekDbModelId = table.Column<Guid>(nullable: true),
                    GoalDbModelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SimpleTasks_Days_DayDbModelId",
                        column: x => x.DayDbModelId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SimpleTasks_Goals_GoalDbModelId",
                        column: x => x.GoalDbModelId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SimpleTasks_Weeks_WeekDbModelId",
                        column: x => x.WeekDbModelId,
                        principalTable: "Weeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Days_DayResultDbModelId",
                table: "Days",
                column: "DayResultDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_WeekDbModelId",
                table: "Days",
                column: "WeekDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Goals_SprintDbModelId",
                table: "Goals",
                column: "SprintDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitResults_DayDbModelId",
                table: "HabitResults",
                column: "DayDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_HabitResults_HabitDbModelId",
                table: "HabitResults",
                column: "HabitDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Habits_SprintDbModelId",
                table: "Habits",
                column: "SprintDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_GoalDbModelId",
                table: "Milestones",
                column: "GoalDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_WeekDbModelId",
                table: "Milestones",
                column: "WeekDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleTasks_DayDbModelId",
                table: "SimpleTasks",
                column: "DayDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleTasks_GoalDbModelId",
                table: "SimpleTasks",
                column: "GoalDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleTasks_WeekDbModelId",
                table: "SimpleTasks",
                column: "WeekDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_SprintResultDbModelId",
                table: "Sprints",
                column: "SprintResultDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_SprintDbModelId",
                table: "Weeks",
                column: "SprintDbModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_WeekResultDbModelId",
                table: "Weeks",
                column: "WeekResultDbModelId");
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
