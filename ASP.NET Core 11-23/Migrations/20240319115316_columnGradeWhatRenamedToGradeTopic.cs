using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_Core_11_23.Migrations
{
    public partial class columnGradeWhatRenamedToGradeTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "What",
                table: "Grades",
                newName: "Topic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Topic",
                table: "Grades",
                newName: "What");
        }
    }
}
