using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace library.Migrations
{
    public partial class _160422_2150 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sch_library");

            migrationBuilder.CreateTable(
                name: "author",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    author_id = table.Column<int>(type: "integer", nullable: false),
                    author_fullname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    author_country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "genre",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    genre_id = table.Column<int>(type: "integer", nullable: false),
                    genre_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "publisher",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    publisher_id = table.Column<int>(type: "integer", nullable: false),
                    publisher_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "section",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    section_id = table.Column<int>(type: "integer", nullable: false),
                    section_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    status_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "book",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    book_id = table.Column<int>(type: "integer", nullable: false),
                    book_name = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    book_count = table.Column<int>(type: "integer", nullable: true),
                    book_description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    book_age_restriction = table.Column<int>(type: "integer", nullable: true),
                    bookmark_id = table.Column<int>(type: "integer", nullable: true),
                    rating_id = table.Column<int>(type: "integer", nullable: true),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    section_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.Id);
                    table.ForeignKey(
                        name: "book_section_id_fkey",
                        column: x => x.section_id,
                        principalSchema: "sch_library",
                        principalTable: "section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "book_status_id_fkey",
                        column: x => x.status_id,
                        principalSchema: "sch_library",
                        principalTable: "status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "author_to_book",
                schema: "sch_library",
                columns: table => new
                {
                    author_id = table.Column<int>(type: "integer", nullable: false),
                    book_id = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("author_to_book_pkey", x => new { x.author_id, x.book_id });
                    table.ForeignKey(
                        name: "author_to_book_author_id_fkey",
                        column: x => x.author_id,
                        principalSchema: "sch_library",
                        principalTable: "author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "author_to_book_book_id_fkey",
                        column: x => x.book_id,
                        principalSchema: "sch_library",
                        principalTable: "book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "edition",
                schema: "sch_library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    edition_id = table.Column<int>(type: "integer", nullable: false),
                    edition_isbn = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    edition_number = table.Column<int>(type: "integer", nullable: false),
                    edition_publication = table.Column<DateTime>(type: "date", nullable: true),
                    edition_length = table.Column<int>(type: "integer", nullable: true),
                    edition_type = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: true),
                    publisher_id = table.Column<int>(type: "integer", nullable: false),
                    book_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_edition", x => x.Id);
                    table.ForeignKey(
                        name: "edition_book_id_fkey",
                        column: x => x.book_id,
                        principalSchema: "sch_library",
                        principalTable: "book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "edition_publisher_id_fkey",
                        column: x => x.publisher_id,
                        principalSchema: "sch_library",
                        principalTable: "publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "genre_to_book",
                schema: "sch_library",
                columns: table => new
                {
                    genre_id = table.Column<int>(type: "integer", nullable: false),
                    book_id = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("genre_to_book_pkey", x => new { x.genre_id, x.book_id });
                    table.ForeignKey(
                        name: "genre_to_book_book_id_fkey",
                        column: x => x.book_id,
                        principalSchema: "sch_library",
                        principalTable: "book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "genre_to_book_genre_id_fkey",
                        column: x => x.genre_id,
                        principalSchema: "sch_library",
                        principalTable: "genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_author_to_book_book_id",
                schema: "sch_library",
                table: "author_to_book",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_section_id",
                schema: "sch_library",
                table: "book",
                column: "section_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_status_id",
                schema: "sch_library",
                table: "book",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_edition_book_id",
                schema: "sch_library",
                table: "edition",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_edition_publisher_id",
                schema: "sch_library",
                table: "edition",
                column: "publisher_id");

            migrationBuilder.CreateIndex(
                name: "IX_genre_to_book_book_id",
                schema: "sch_library",
                table: "genre_to_book",
                column: "book_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "author_to_book",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "edition",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "genre_to_book",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "author",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "publisher",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "book",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "genre",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "section",
                schema: "sch_library");

            migrationBuilder.DropTable(
                name: "status",
                schema: "sch_library");
        }
    }
}
