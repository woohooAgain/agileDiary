using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AltAgileDiary.Data.Migrations
{
    public partial class addHabbitToSprintViewAndController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habit_Sprint_SprintId",
                table: "Habit");

            migrationBuilder.AlterColumn<Guid>(
                name: "SprintId",
                table: "Habit",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Habit",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Habit_Sprint_SprintId",
                table: "Habit",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habit_Sprint_SprintId",
                table: "Habit");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Habit");

            migrationBuilder.AlterColumn<Guid>(
                name: "SprintId",
                table: "Habit",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Habit_Sprint_SprintId",
                table: "Habit",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
