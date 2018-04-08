using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AltAgileDiary.Data.Migrations
{
    public partial class addSprintId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_Sprint_SprintId",
                table: "Goal");

            migrationBuilder.AlterColumn<Guid>(
                name: "SprintId",
                table: "Goal",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_Sprint_SprintId",
                table: "Goal",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Goal_Sprint_SprintId",
                table: "Goal");

            migrationBuilder.AlterColumn<Guid>(
                name: "SprintId",
                table: "Goal",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Goal_Sprint_SprintId",
                table: "Goal",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
