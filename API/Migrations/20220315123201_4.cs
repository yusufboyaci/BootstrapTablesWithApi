using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Login_Kisiler_KisiId",
                table: "Login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "Loginler");

            migrationBuilder.RenameIndex(
                name: "IX_Login_KisiId",
                table: "Loginler",
                newName: "IX_Loginler_KisiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loginler",
                table: "Loginler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loginler_Kisiler_KisiId",
                table: "Loginler",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loginler_Kisiler_KisiId",
                table: "Loginler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loginler",
                table: "Loginler");

            migrationBuilder.RenameTable(
                name: "Loginler",
                newName: "Login");

            migrationBuilder.RenameIndex(
                name: "IX_Loginler_KisiId",
                table: "Login",
                newName: "IX_Login_KisiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Login_Kisiler_KisiId",
                table: "Login",
                column: "KisiId",
                principalTable: "Kisiler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
