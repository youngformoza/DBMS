using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryAPI.Migrations
{
    public partial class _180422_2230 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorToBooks_Authors_AuthorId",
                table: "AuthorToBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorToBooks_Books_BookId",
                table: "AuthorToBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Sections_SectionId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Statuses_StatusId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Books_BookId",
                table: "Editions");

            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Publishers_PublisherId",
                table: "Editions");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreToBooks_Books_BookId",
                table: "GenreToBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreToBooks_Genres_GenreId",
                table: "GenreToBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenreToBooks",
                table: "GenreToBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorToBooks",
                table: "AuthorToBooks");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "statuses");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "sections");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "publishers");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "genres");

            migrationBuilder.RenameTable(
                name: "Editions",
                newName: "editions");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "authors");

            migrationBuilder.RenameTable(
                name: "GenreToBooks",
                newName: "genres_to_books");

            migrationBuilder.RenameTable(
                name: "AuthorToBooks",
                newName: "authors_to_books");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "statuses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "statuses",
                newName: "status_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sections",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SectionName",
                table: "sections",
                newName: "section_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "publishers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "publishers",
                newName: "publisher_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "genres",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "genres",
                newName: "genre_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "editions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "editions",
                newName: "publisher_id");

            migrationBuilder.RenameColumn(
                name: "EditionType",
                table: "editions",
                newName: "edition_type");

            migrationBuilder.RenameColumn(
                name: "EditionPublication",
                table: "editions",
                newName: "edition_publication");

            migrationBuilder.RenameColumn(
                name: "EditionNumber",
                table: "editions",
                newName: "edition_number");

            migrationBuilder.RenameColumn(
                name: "EditionLength",
                table: "editions",
                newName: "edition_length");

            migrationBuilder.RenameColumn(
                name: "EditionIsbn",
                table: "editions",
                newName: "edition_ISBN");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "editions",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_Editions_PublisherId",
                table: "editions",
                newName: "IX_editions_publisher_id");

            migrationBuilder.RenameIndex(
                name: "IX_Editions_BookId",
                table: "editions",
                newName: "IX_editions_book_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "books",
                newName: "status_id");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "books",
                newName: "section_id");

            migrationBuilder.RenameColumn(
                name: "RatingId",
                table: "books",
                newName: "rating_id");

            migrationBuilder.RenameColumn(
                name: "BookmarkId",
                table: "books",
                newName: "bookmark_id");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "books",
                newName: "book_name");

            migrationBuilder.RenameColumn(
                name: "BookDescription",
                table: "books",
                newName: "book_description");

            migrationBuilder.RenameColumn(
                name: "BookCount",
                table: "books",
                newName: "book_count");

            migrationBuilder.RenameColumn(
                name: "BookAgeRestriction",
                table: "books",
                newName: "book_age_restriction");

            migrationBuilder.RenameIndex(
                name: "IX_Books_StatusId",
                table: "books",
                newName: "IX_books_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_Books_SectionId",
                table: "books",
                newName: "IX_books_section_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "authors",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "AuthorFullname",
                table: "authors",
                newName: "author_fullname");

            migrationBuilder.RenameColumn(
                name: "AuthorCountry",
                table: "authors",
                newName: "author_country");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "genres_to_books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "genres_to_books",
                newName: "genre_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "genres_to_books",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_GenreToBooks_GenreId",
                table: "genres_to_books",
                newName: "IX_genres_to_books_genre_id");

            migrationBuilder.RenameIndex(
                name: "IX_GenreToBooks_BookId",
                table: "genres_to_books",
                newName: "IX_genres_to_books_book_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "authors_to_books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "authors_to_books",
                newName: "book_id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "authors_to_books",
                newName: "author_id");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorToBooks_BookId",
                table: "authors_to_books",
                newName: "IX_authors_to_books_book_id");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorToBooks_AuthorId",
                table: "authors_to_books",
                newName: "IX_authors_to_books_author_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_statuses",
                table: "statuses",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sections",
                table: "sections",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_publishers",
                table: "publishers",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres",
                table: "genres",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_editions",
                table: "editions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors",
                table: "authors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres_to_books",
                table: "genres_to_books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors_to_books",
                table: "authors_to_books",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_authors_to_books_authors_author_id",
                table: "authors_to_books",
                column: "author_id",
                principalTable: "authors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_authors_to_books_books_book_id",
                table: "authors_to_books",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_books_sections_section_id",
                table: "books",
                column: "section_id",
                principalTable: "sections",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_books_statuses_status_id",
                table: "books",
                column: "status_id",
                principalTable: "statuses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_editions_books_book_id",
                table: "editions",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_editions_publishers_publisher_id",
                table: "editions",
                column: "publisher_id",
                principalTable: "publishers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genres_to_books_books_book_id",
                table: "genres_to_books",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genres_to_books_genres_genre_id",
                table: "genres_to_books",
                column: "genre_id",
                principalTable: "genres",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_authors_to_books_authors_author_id",
                table: "authors_to_books");

            migrationBuilder.DropForeignKey(
                name: "FK_authors_to_books_books_book_id",
                table: "authors_to_books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_sections_section_id",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_books_statuses_status_id",
                table: "books");

            migrationBuilder.DropForeignKey(
                name: "FK_editions_books_book_id",
                table: "editions");

            migrationBuilder.DropForeignKey(
                name: "FK_editions_publishers_publisher_id",
                table: "editions");

            migrationBuilder.DropForeignKey(
                name: "FK_genres_to_books_books_book_id",
                table: "genres_to_books");

            migrationBuilder.DropForeignKey(
                name: "FK_genres_to_books_genres_genre_id",
                table: "genres_to_books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_statuses",
                table: "statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sections",
                table: "sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publishers",
                table: "publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genres",
                table: "genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_editions",
                table: "editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors",
                table: "authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_genres_to_books",
                table: "genres_to_books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors_to_books",
                table: "authors_to_books");

            migrationBuilder.RenameTable(
                name: "statuses",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "sections",
                newName: "Sections");

            migrationBuilder.RenameTable(
                name: "publishers",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "genres",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "editions",
                newName: "Editions");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "authors",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "genres_to_books",
                newName: "GenreToBooks");

            migrationBuilder.RenameTable(
                name: "authors_to_books",
                newName: "AuthorToBooks");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Statuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status_name",
                table: "Statuses",
                newName: "StatusName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Sections",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "section_name",
                table: "Sections",
                newName: "SectionName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Publishers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "publisher_name",
                table: "Publishers",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "genre_name",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Editions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "publisher_id",
                table: "Editions",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "edition_type",
                table: "Editions",
                newName: "EditionType");

            migrationBuilder.RenameColumn(
                name: "edition_publication",
                table: "Editions",
                newName: "EditionPublication");

            migrationBuilder.RenameColumn(
                name: "edition_number",
                table: "Editions",
                newName: "EditionNumber");

            migrationBuilder.RenameColumn(
                name: "edition_length",
                table: "Editions",
                newName: "EditionLength");

            migrationBuilder.RenameColumn(
                name: "edition_ISBN",
                table: "Editions",
                newName: "EditionIsbn");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "Editions",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_editions_publisher_id",
                table: "Editions",
                newName: "IX_Editions_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_editions_book_id",
                table: "Editions",
                newName: "IX_Editions_BookId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status_id",
                table: "Books",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "section_id",
                table: "Books",
                newName: "SectionId");

            migrationBuilder.RenameColumn(
                name: "rating_id",
                table: "Books",
                newName: "RatingId");

            migrationBuilder.RenameColumn(
                name: "bookmark_id",
                table: "Books",
                newName: "BookmarkId");

            migrationBuilder.RenameColumn(
                name: "book_name",
                table: "Books",
                newName: "BookName");

            migrationBuilder.RenameColumn(
                name: "book_description",
                table: "Books",
                newName: "BookDescription");

            migrationBuilder.RenameColumn(
                name: "book_count",
                table: "Books",
                newName: "BookCount");

            migrationBuilder.RenameColumn(
                name: "book_age_restriction",
                table: "Books",
                newName: "BookAgeRestriction");

            migrationBuilder.RenameIndex(
                name: "IX_books_status_id",
                table: "Books",
                newName: "IX_Books_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_books_section_id",
                table: "Books",
                newName: "IX_Books_SectionId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Authors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "author_fullname",
                table: "Authors",
                newName: "AuthorFullname");

            migrationBuilder.RenameColumn(
                name: "author_country",
                table: "Authors",
                newName: "AuthorCountry");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "GenreToBooks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "genre_id",
                table: "GenreToBooks",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "GenreToBooks",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_genres_to_books_genre_id",
                table: "GenreToBooks",
                newName: "IX_GenreToBooks_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_genres_to_books_book_id",
                table: "GenreToBooks",
                newName: "IX_GenreToBooks_BookId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AuthorToBooks",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "AuthorToBooks",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "author_id",
                table: "AuthorToBooks",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_authors_to_books_book_id",
                table: "AuthorToBooks",
                newName: "IX_AuthorToBooks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_authors_to_books_author_id",
                table: "AuthorToBooks",
                newName: "IX_AuthorToBooks_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                table: "Editions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenreToBooks",
                table: "GenreToBooks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorToBooks",
                table: "AuthorToBooks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorToBooks_Authors_AuthorId",
                table: "AuthorToBooks",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorToBooks_Books_BookId",
                table: "AuthorToBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Sections_SectionId",
                table: "Books",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Statuses_StatusId",
                table: "Books",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Books_BookId",
                table: "Editions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Publishers_PublisherId",
                table: "Editions",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreToBooks_Books_BookId",
                table: "GenreToBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreToBooks_Genres_GenreId",
                table: "GenreToBooks",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
