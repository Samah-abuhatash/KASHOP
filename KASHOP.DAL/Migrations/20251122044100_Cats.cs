using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KASHOP.DAl.Migrations
{
    /// <inheritdoc />
    public partial class Cats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Catgores");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAT",
                table: "Catgores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Catgores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "transelation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transelation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transelation_Catgores_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catgores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transelation_CategoryId",
                table: "transelation",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transelation");

            migrationBuilder.DropColumn(
                name: "CreatedAT",
                table: "Catgores");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Catgores");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Catgores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
