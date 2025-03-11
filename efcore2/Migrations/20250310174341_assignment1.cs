using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore2.Migrations
{
    /// <inheritdoc />
    public partial class assignment1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_course_Insts_student_stud_idid",
                table: "course_Insts");

            migrationBuilder.RenameColumn(
                name: "stud_idid",
                table: "course_Insts",
                newName: "course_idid");

            migrationBuilder.RenameIndex(
                name: "IX_course_Insts_stud_idid",
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
                newName: "stud_idid");

            migrationBuilder.RenameIndex(
                name: "IX_course_Insts_course_idid",
                table: "course_Insts",
                newName: "IX_course_Insts_stud_idid");

            migrationBuilder.AddForeignKey(
                name: "FK_course_Insts_student_stud_idid",
                table: "course_Insts",
                column: "stud_idid",
                principalTable: "student",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
