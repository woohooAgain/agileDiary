using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class UpgradeDbModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Task",
                newName: "TaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Task",
                newName: "Id");
        }
    }
}
