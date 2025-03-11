using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore2.Migrations
{
    /// <inheritdoc />
    public partial class assignmnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dept_id",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "ins_id",
                table: "departments");

            migrationBuilder.CreateTable(
                name: "course_Insts",
                columns: table => new
                {
                    stud_idid = table.Column<int>(type: "int", nullable: false),
                    inst_idid = table.Column<int>(type: "int", nullable: false),
                    evalute = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_course_Insts_instructors_inst_idid",
                        column: x => x.inst_idid,
                        principalTable: "instructors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_Insts_student_stud_idid",
                        column: x => x.stud_idid,
                        principalTable: "student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "departmentinstructor",
                columns: table => new
                {
                    dept_id = table.Column<int>(type: "int", nullable: false),
                    ins_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmentinstructor", x => new { x.dept_id, x.ins_id });
                    table.ForeignKey(
                        name: "FK_departmentinstructor_departments_ins_id",
                        column: x => x.ins_id,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_departmentinstructor_instructors_dept_id",
                        column: x => x.dept_id,
                        principalTable: "instructors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stud_Courses",
                columns: table => new
                {
                    stud_idid = table.Column<int>(type: "int", nullable: false),
                    course_idid = table.Column<int>(type: "int", nullable: false),
                    grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_stud_Courses_courses_course_idid",
                        column: x => x.course_idid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stud_Courses_student_stud_idid",
                        column: x => x.stud_idid,
                        principalTable: "student",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_course_Insts_inst_idid",
                table: "course_Insts",
                column: "inst_idid");

            migrationBuilder.CreateIndex(
                name: "IX_course_Insts_stud_idid",
                table: "course_Insts",
                column: "stud_idid");

            migrationBuilder.CreateIndex(
                name: "IX_departmentinstructor_ins_id",
                table: "departmentinstructor",
                column: "ins_id");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_course_idid",
                table: "stud_Courses",
                column: "course_idid");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_stud_idid",
                table: "stud_Courses",
                column: "stud_idid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_Insts");

            migrationBuilder.DropTable(
                name: "departmentinstructor");

            migrationBuilder.DropTable(
                name: "stud_Courses");

            migrationBuilder.AddColumn<int>(
                name: "dept_id",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ins_id",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
