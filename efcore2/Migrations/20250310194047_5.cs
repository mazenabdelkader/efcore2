using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore2.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topicid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hiring_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    insid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "topic",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topic", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bonus = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hourrate = table.Column<int>(type: "int", nullable: false),
                    dept_id = table.Column<int>(type: "int", nullable: false),
                    mangedepartmentid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.id);
                    table.ForeignKey(
                        name: "FK_instructors_departments_dept_id",
                        column: x => x.dept_id,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_instructors_departments_mangedepartmentid",
                        column: x => x.mangedepartmentid,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    dept_id = table.Column<int>(type: "int", nullable: false),
                    departmentid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.id);
                    table.ForeignKey(
                        name: "FK_student_departments_departmentid",
                        column: x => x.departmentid,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "course_Insts",
                columns: table => new
                {
                    course_idid = table.Column<int>(type: "int", nullable: false),
                    inst_idid = table.Column<int>(type: "int", nullable: false),
                    evalute = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_course_Insts_courses_course_idid",
                        column: x => x.course_idid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_Insts_instructors_inst_idid",
                        column: x => x.inst_idid,
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
                name: "IX_course_Insts_course_idid",
                table: "course_Insts",
                column: "course_idid");

            migrationBuilder.CreateIndex(
                name: "IX_course_Insts_inst_idid",
                table: "course_Insts",
                column: "inst_idid");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_dept_id",
                table: "instructors",
                column: "dept_id");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_mangedepartmentid",
                table: "instructors",
                column: "mangedepartmentid");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_course_idid",
                table: "stud_Courses",
                column: "course_idid");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_stud_idid",
                table: "stud_Courses",
                column: "stud_idid");

            migrationBuilder.CreateIndex(
                name: "IX_student_departmentid",
                table: "student",
                column: "departmentid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_Insts");

            migrationBuilder.DropTable(
                name: "stud_Courses");

            migrationBuilder.DropTable(
                name: "topic");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
