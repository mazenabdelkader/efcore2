using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcore2.Migrations
{
    /// <inheritdoc />
    public partial class _0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_courses_topicid",
                table: "courses",
                column: "topicid");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_topic_topicid",
                table: "courses",
                column: "topicid",
                principalTable: "topic",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_topic_topicid",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_topicid",
                table: "courses");
        }
    }
}
