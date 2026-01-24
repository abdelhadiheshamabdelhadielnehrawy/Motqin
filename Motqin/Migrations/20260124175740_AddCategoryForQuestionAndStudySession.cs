using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Motqin.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryForQuestionAndStudySession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionsCategory",
                table: "StudySessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QuestionCategory",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionsCategory",
                table: "StudySessions");

            migrationBuilder.DropColumn(
                name: "QuestionCategory",
                table: "Questions");
        }
    }
}
