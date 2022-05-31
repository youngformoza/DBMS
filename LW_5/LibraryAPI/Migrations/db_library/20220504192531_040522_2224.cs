using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class _040522_2224 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "statuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "sections",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "publishers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "genres_to_books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "editions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "authors_to_books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "authors",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "statuses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sections",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "publishers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "genres_to_books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "genres",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "editions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "authors_to_books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "authors",
                newName: "id");
        }
    }
}
