using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Motqin.Migrations
{
    /// <inheritdoc />
    public partial class RefactorSessionsInheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectID",
                table: "StudySessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudySessions_SubjectID",
                table: "StudySessions",
                column: "SubjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudySessions_Lessons_SubjectID",
                table: "StudySessions",
                column: "SubjectID",
                principalTable: "Lessons",
                principalColumn: "LessonID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudySessions_Lessons_SubjectID",
                table: "StudySessions");

            migrationBuilder.DropIndex(
                name: "IX_StudySessions_SubjectID",
                table: "StudySessions");

            migrationBuilder.DropColumn(
                name: "SubjectID",
                table: "StudySessions");
        }
    }
}
