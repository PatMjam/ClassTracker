using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassTracker.Migrations
{
    public partial class Teacherseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "TeacherEmail", "TeacherName", "TeacherPhone" },
                values: new object[] { 1, "mhour25@eq.edu.au", "Melissa", "0410541265" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "TeacherEmail", "TeacherName", "TeacherPhone" },
                values: new object[] { 2, "ekala1@eq.edu.au", "Erick", "0415752145" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);
        }
    }
}
