using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loginler_Kisiler_KisiId",
                table: "Loginler");

            migrationBuilder.DropIndex(
                name: "IX_Loginler_KisiId",
                table: "Loginler");

            migrationBuilder.DropColumn(
                name: "KisiId",
                table: "Loginler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KisiId",
                table: "Loginler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loginler_KisiId",
                table: "Loginler",
                column: "KisiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loginler_Kisiler_KisiId",
                table: "Loginler",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
