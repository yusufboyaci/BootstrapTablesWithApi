﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdresDefterleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Konum = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KisiId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresDefterleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdresDefterleri_Kisiler_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdresDefterleri_KisiId",
                table: "AdresDefterleri",
                column: "KisiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdresDefterleri");

            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
