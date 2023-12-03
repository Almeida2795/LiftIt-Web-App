using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLiftItt.Migrations
{
    /// <inheritdoc />
    public partial class fixedRelationshipsBetweenSetsnWorkoutExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkoutExerciseId",
                table: "Sets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sets_WorkoutExerciseId",
                table: "Sets",
                column: "WorkoutExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_WorkoutExercise_WorkoutExerciseId",
                table: "Sets",
                column: "WorkoutExerciseId",
                principalTable: "WorkoutExercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_WorkoutExercise_WorkoutExerciseId",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Sets_WorkoutExerciseId",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "WorkoutExerciseId",
                table: "Sets");
        }
    }
}
