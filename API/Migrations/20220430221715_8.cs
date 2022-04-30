using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Kisiler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Kisiler",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
