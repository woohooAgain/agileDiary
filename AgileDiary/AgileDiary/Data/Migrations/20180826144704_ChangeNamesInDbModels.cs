using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileDiary.Data.Migrations
{
    public partial class ChangeNamesInDbModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Results_DayResultDbModelId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Days_Weeks_WeekDbModelId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Sprints_SprintDbModelId",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_HabitResults_Days_DayDbModelId",
                table: "HabitResults");

            migrationBuilder.DropForeignKey(
                name: "FK_HabitResults_Habits_HabitDbModelId",
                table: "HabitResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Habits_Sprints_SprintDbModelId",
                table: "Habits");

            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Weeks_WeekDbModelId",
                table: "Milestones");

            migrationBuilder.DropForeignKey(
                name: "FK_SimpleTasks_Days_DayDbModelId",
                table: "SimpleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SimpleTasks_Goals_GoalDbModelId",
                table: "SimpleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SimpleTasks_Weeks_WeekDbModelId",
                table: "SimpleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Results_SprintResultDbModelId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_Sprints_SprintDbModelId",
                table: "Weeks");

            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_Results_WeekResultDbModelId",
                table: "Weeks");

            migrationBuilder.RenameColumn(
                name: "WeekResultDbModelId",
                table: "Weeks",
                newName: "WeekResultId");

            migrationBuilder.RenameColumn(
                name: "SprintDbModelId",
                table: "Weeks",
                newName: "SprintId");

            migrationBuilder.RenameIndex(
                name: "IX_Weeks_WeekResultDbModelId",
                table: "Weeks",
                newName: "IX_Weeks_WeekResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Weeks_SprintDbModelId",
                table: "Weeks",
                newName: "IX_Weeks_SprintId");

            migrationBuilder.RenameColumn(
                name: "SprintResultDbModelId",
                table: "Sprints",
                newName: "SprintResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Sprints_SprintResultDbModelId",
                table: "Sprints",
                newName: "IX_Sprints_SprintResultId");

            migrationBuilder.RenameColumn(
                name: "WeekDbModelId",
                table: "SimpleTasks",
                newName: "WeekId");

            migrationBuilder.RenameColumn(
                name: "GoalDbModelId",
                table: "SimpleTasks",
                newName: "GoalId");

            migrationBuilder.RenameColumn(
                name: "DayDbModelId",
                table: "SimpleTasks",
                newName: "DayId");

            migrationBuilder.RenameIndex(
                name: "IX_SimpleTasks_WeekDbModelId",
                table: "SimpleTasks",
                newName: "IX_SimpleTasks_WeekId");

            migrationBuilder.RenameIndex(
                name: "IX_SimpleTasks_GoalDbModelId",
                table: "SimpleTasks",
                newName: "IX_SimpleTasks_GoalId");

            migrationBuilder.RenameIndex(
                name: "IX_SimpleTasks_DayDbModelId",
                table: "SimpleTasks",
                newName: "IX_SimpleTasks_DayId");

            migrationBuilder.RenameColumn(
                name: "WeekDbModelId",
                table: "Milestones",
                newName: "WeekId");

            migrationBuilder.RenameIndex(
                name: "IX_Milestones_WeekDbModelId",
                table: "Milestones",
                newName: "IX_Milestones_WeekId");

            migrationBuilder.RenameColumn(
                name: "SprintDbModelId",
                table: "Habits",
                newName: "SprintId");

            migrationBuilder.RenameIndex(
                name: "IX_Habits_SprintDbModelId",
                table: "Habits",
                newName: "IX_Habits_SprintId");

            migrationBuilder.RenameColumn(
                name: "HabitDbModelId",
                table: "HabitResults",
                newName: "HabitId");

            migrationBuilder.RenameColumn(
                name: "DayDbModelId",
                table: "HabitResults",
                newName: "DayId");

            migrationBuilder.RenameIndex(
                name: "IX_HabitResults_HabitDbModelId",
                table: "HabitResults",
                newName: "IX_HabitResults_HabitId");

            migrationBuilder.RenameIndex(
                name: "IX_HabitResults_DayDbModelId",
                table: "HabitResults",
                newName: "IX_HabitResults_DayId");

            migrationBuilder.RenameColumn(
                name: "SprintDbModelId",
                table: "Goals",
                newName: "SprintId");

            migrationBuilder.RenameIndex(
                name: "IX_Goals_SprintDbModelId",
                table: "Goals",
                newName: "IX_Goals_SprintId");

            migrationBuilder.RenameColumn(
                name: "WeekDbModelId",
                table: "Days",
                newName: "WeekId");

            migrationBuilder.RenameColumn(
                name: "DayResultDbModelId",
                table: "Days",
                newName: "DayResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_WeekDbModelId",
                table: "Days",
                newName: "IX_Days_WeekId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_DayResultDbModelId",
                table: "Days",
                newName: "IX_Days_DayResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Results_DayResultId",
                table: "Days",
                column: "DayResultId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Weeks_WeekId",
                table: "Days",
                column: "WeekId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Sprints_SprintId",
                table: "Goals",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitResults_Days_DayId",
                table: "HabitResults",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitResults_Habits_HabitId",
                table: "HabitResults",
                column: "HabitId",
                principalTable: "Habits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Habits_Sprints_SprintId",
                table: "Habits",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Weeks_WeekId",
                table: "Milestones",
                column: "WeekId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SimpleTasks_Days_DayId",
                table: "SimpleTasks",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SimpleTasks_Goals_GoalId",
                table: "SimpleTasks",
                column: "GoalId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SimpleTasks_Weeks_WeekId",
                table: "SimpleTasks",
                column: "WeekId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Results_SprintResultId",
                table: "Sprints",
                column: "SprintResultId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_Sprints_SprintId",
                table: "Weeks",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_Results_WeekResultId",
                table: "Weeks",
                column: "WeekResultId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Results_DayResultId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Days_Weeks_WeekId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Goals_Sprints_SprintId",
                table: "Goals");

            migrationBuilder.DropForeignKey(
                name: "FK_HabitResults_Days_DayId",
                table: "HabitResults");

            migrationBuilder.DropForeignKey(
                name: "FK_HabitResults_Habits_HabitId",
                table: "HabitResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Habits_Sprints_SprintId",
                table: "Habits");

            migrationBuilder.DropForeignKey(
                name: "FK_Milestones_Weeks_WeekId",
                table: "Milestones");

            migrationBuilder.DropForeignKey(
                name: "FK_SimpleTasks_Days_DayId",
                table: "SimpleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SimpleTasks_Goals_GoalId",
                table: "SimpleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SimpleTasks_Weeks_WeekId",
                table: "SimpleTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Results_SprintResultId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_Sprints_SprintId",
                table: "Weeks");

            migrationBuilder.DropForeignKey(
                name: "FK_Weeks_Results_WeekResultId",
                table: "Weeks");

            migrationBuilder.RenameColumn(
                name: "WeekResultId",
                table: "Weeks",
                newName: "WeekResultDbModelId");

            migrationBuilder.RenameColumn(
                name: "SprintId",
                table: "Weeks",
                newName: "SprintDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Weeks_WeekResultId",
                table: "Weeks",
                newName: "IX_Weeks_WeekResultDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Weeks_SprintId",
                table: "Weeks",
                newName: "IX_Weeks_SprintDbModelId");

            migrationBuilder.RenameColumn(
                name: "SprintResultId",
                table: "Sprints",
                newName: "SprintResultDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Sprints_SprintResultId",
                table: "Sprints",
                newName: "IX_Sprints_SprintResultDbModelId");

            migrationBuilder.RenameColumn(
                name: "WeekId",
                table: "SimpleTasks",
                newName: "WeekDbModelId");

            migrationBuilder.RenameColumn(
                name: "GoalId",
                table: "SimpleTasks",
                newName: "GoalDbModelId");

            migrationBuilder.RenameColumn(
                name: "DayId",
                table: "SimpleTasks",
                newName: "DayDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_SimpleTasks_WeekId",
                table: "SimpleTasks",
                newName: "IX_SimpleTasks_WeekDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_SimpleTasks_GoalId",
                table: "SimpleTasks",
                newName: "IX_SimpleTasks_GoalDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_SimpleTasks_DayId",
                table: "SimpleTasks",
                newName: "IX_SimpleTasks_DayDbModelId");

            migrationBuilder.RenameColumn(
                name: "WeekId",
                table: "Milestones",
                newName: "WeekDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Milestones_WeekId",
                table: "Milestones",
                newName: "IX_Milestones_WeekDbModelId");

            migrationBuilder.RenameColumn(
                name: "SprintId",
                table: "Habits",
                newName: "SprintDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Habits_SprintId",
                table: "Habits",
                newName: "IX_Habits_SprintDbModelId");

            migrationBuilder.RenameColumn(
                name: "HabitId",
                table: "HabitResults",
                newName: "HabitDbModelId");

            migrationBuilder.RenameColumn(
                name: "DayId",
                table: "HabitResults",
                newName: "DayDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_HabitResults_HabitId",
                table: "HabitResults",
                newName: "IX_HabitResults_HabitDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_HabitResults_DayId",
                table: "HabitResults",
                newName: "IX_HabitResults_DayDbModelId");

            migrationBuilder.RenameColumn(
                name: "SprintId",
                table: "Goals",
                newName: "SprintDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Goals_SprintId",
                table: "Goals",
                newName: "IX_Goals_SprintDbModelId");

            migrationBuilder.RenameColumn(
                name: "WeekId",
                table: "Days",
                newName: "WeekDbModelId");

            migrationBuilder.RenameColumn(
                name: "DayResultId",
                table: "Days",
                newName: "DayResultDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_WeekId",
                table: "Days",
                newName: "IX_Days_WeekDbModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_DayResultId",
                table: "Days",
                newName: "IX_Days_DayResultDbModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Results_DayResultDbModelId",
                table: "Days",
                column: "DayResultDbModelId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Weeks_WeekDbModelId",
                table: "Days",
                column: "WeekDbModelId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Goals_Sprints_SprintDbModelId",
                table: "Goals",
                column: "SprintDbModelId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitResults_Days_DayDbModelId",
                table: "HabitResults",
                column: "DayDbModelId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HabitResults_Habits_HabitDbModelId",
                table: "HabitResults",
                column: "HabitDbModelId",
                principalTable: "Habits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Habits_Sprints_SprintDbModelId",
                table: "Habits",
                column: "SprintDbModelId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Milestones_Weeks_WeekDbModelId",
                table: "Milestones",
                column: "WeekDbModelId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SimpleTasks_Days_DayDbModelId",
                table: "SimpleTasks",
                column: "DayDbModelId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SimpleTasks_Goals_GoalDbModelId",
                table: "SimpleTasks",
                column: "GoalDbModelId",
                principalTable: "Goals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SimpleTasks_Weeks_WeekDbModelId",
                table: "SimpleTasks",
                column: "WeekDbModelId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Results_SprintResultDbModelId",
                table: "Sprints",
                column: "SprintResultDbModelId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_Sprints_SprintDbModelId",
                table: "Weeks",
                column: "SprintDbModelId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weeks_Results_WeekResultDbModelId",
                table: "Weeks",
                column: "WeekResultDbModelId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
