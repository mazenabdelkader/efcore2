using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore2.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Insts_courses_courseid",
                table: "course_Insts");

            migrationBuilder.DropColumn(
                name: "course_id",
                table: "course_Insts");

            migrationBuilder.RenameColumn(
                name: "courseid",
                table: "course_Insts",
                newName: "course_idid");

            migrationBuilder.RenameIndex(
                name: "IX_course_Insts_courseid",
                table: "course_Insts",
                newName: "IX_course_Insts_course_idid");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Insts_courses_course_idid",
                table: "course_Insts",
                column: "course_idid",
                principalTable: "courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Insts_courses_course_idid",
                table: "course_Insts");

            migrationBuilder.RenameColumn(
                name: "course_idid",
                table: "course_Insts",
                newName: "courseid");

            migrationBuilder.RenameIndex(
                name: "IX_course_Insts_course_idid",
                table: "course_Insts",
                newName: "IX_course_Insts_courseid");

            migrationBuilder.AddColumn<int>(
                name: "course_id",
                table: "course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_course_Insts_courses_courseid",
                table: "course_Insts",
                column: "courseid",
                principalTable: "courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
