using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class AddTasksToWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    WeekId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Week_WeekId",
                        column: x => x.WeekId,
                        principalTable: "Week",
                        principalColumn: "WeekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_WeekId",
                table: "Task",
                column: "WeekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");

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

            migrationBuilder.CreateIndex(
                name: "IX_Day_WeekId",
                table: "Day",
                column: "WeekId");
        }
    }
}
