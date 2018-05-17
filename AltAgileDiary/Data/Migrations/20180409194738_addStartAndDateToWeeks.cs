using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AltAgileDiary.Data.Migrations
{
    public partial class addStartAndDateToWeeks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_Sprint_SprintId",
                table: "Weeks");

            migrationBuilder.AlterColumn<Guid>(
                name: "SprintId",
                table: "Weeks",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Weeks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Weeks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_Sprint_SprintId",
                table: "Weeks",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_Sprint_SprintId",
                table: "Weeks");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Weeks");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Weeks");

            migrationBuilder.AlterColumn<Guid>(
                name: "SprintId",
                table: "Weeks",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_Sprint_SprintId",
                table: "Weeks",
                column: "SprintId",
                principalTable: "Sprint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
