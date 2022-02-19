using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPFinalProjectNETCORE.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    _Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _ProfilePictureURL = table.Column<string>(nullable: true),
                    _FullName = table.Column<string>(nullable: true),
                    _Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    _Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Logo = table.Column<string>(nullable: true),
                    _Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x._Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    _Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _BookPictureURL = table.Column<string>(nullable: true),
                    _BookName = table.Column<string>(nullable: true),
                    _Pages = table.Column<int>(nullable: false),
                    _Description = table.Column<string>(nullable: true),
                    _Price = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    _BookCategory = table.Column<int>(nullable: false),
                    Author_Id = table.Column<int>(nullable: true),
                    Publisher_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x._Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_Publisher_Id",
                        column: x => x.Publisher_Id,
                        principalTable: "Publishers",
                        principalColumn: "_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author_Id",
                table: "Books",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Publisher_Id",
                table: "Books",
                column: "Publisher_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
