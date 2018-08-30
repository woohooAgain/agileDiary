using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class AddIsActivePropertyToSprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Sprints",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Sprints");
        }
    }
}
