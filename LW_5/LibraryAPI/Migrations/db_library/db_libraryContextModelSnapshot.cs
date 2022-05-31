﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using LibraryAPI;
using LibraryAPI.ApplicationContexts;

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(DbLibraryContext))]
    partial class db_libraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("library.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorCountry")
                        .HasColumnType("text")
                        .HasColumnName("author_country");

                    b.Property<string>("AuthorFullname")
                        .HasColumnType("text")
                        .HasColumnName("author_fullname");

                    b.HasKey("Id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("library.Entities.AuthorToBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("authors_to_books");
                });

            modelBuilder.Entity("library.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BookAgeRestriction")
                        .HasColumnType("integer")
                        .HasColumnName("book_age_restriction");

                    b.Property<int?>("BookCount")
                        .HasColumnType("integer")
                        .HasColumnName("book_count");

                    b.Property<string>("BookDescription")
                        .HasColumnType("text")
                        .HasColumnName("book_description");

                    b.Property<string>("BookName")
                        .HasColumnType("text")
                        .HasColumnName("book_name");

                    b.Property<int?>("BookmarkId")
                        .HasColumnType("integer")
                        .HasColumnName("bookmark_id");

                    b.Property<int?>("RatingId")
                        .HasColumnType("integer")
                        .HasColumnName("rating_id");

                    b.Property<int>("SectionId")
                        .HasColumnType("integer")
                        .HasColumnName("section_id");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("status_id");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("StatusId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("library.Entities.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<string>("EditionIsbn")
                        .HasColumnType("text")
                        .HasColumnName("edition_ISBN");

                    b.Property<int?>("EditionLength")
                        .HasColumnType("integer")
                        .HasColumnName("edition_length");

                    b.Property<int>("EditionNumber")
                        .HasColumnType("integer")
                        .HasColumnName("edition_number");

                    b.Property<DateTime?>("EditionPublication")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("edition_publication");

                    b.Property<string>("EditionType")
                        .HasColumnType("text")
                        .HasColumnName("edition_type");

                    b.Property<int>("PublisherId")
                        .HasColumnType("integer")
                        .HasColumnName("publisher_id");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("editions");
                });

            modelBuilder.Entity("library.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("text")
                        .HasColumnName("genre_name");

                    b.HasKey("Id");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("library.Entities.GenreToBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer")
                        .HasColumnName("genre_id");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("genres_to_books");
                });

            modelBuilder.Entity("library.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PublisherName")
                        .HasColumnType("text")
                        .HasColumnName("publisher_name");

                    b.HasKey("Id");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("library.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("SectionName")
                        .HasColumnType("text")
                        .HasColumnName("section_name");

                    b.HasKey("Id");

                    b.ToTable("sections");
                });

            modelBuilder.Entity("library.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("text")
                        .HasColumnName("status_name");

                    b.HasKey("Id");

                    b.ToTable("statuses");
                });

            modelBuilder.Entity("library.Entities.AuthorToBook", b =>
                {
                    b.HasOne("library.Entities.Author", "Author")
                        .WithMany("AuthorToBooks")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("library.Entities.Book", "Book")
                        .WithMany("AuthorToBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("library.Entities.Book", b =>
                {
                    b.HasOne("library.Entities.Section", "Section")
                        .WithMany("Books")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("library.Entities.Status", "Status")
                        .WithMany("Books")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("library.Entities.Edition", b =>
                {
                    b.HasOne("library.Entities.Book", "Book")
                        .WithMany("Editions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("library.Entities.Publisher", "Publisher")
                        .WithMany("Editions")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("library.Entities.GenreToBook", b =>
                {
                    b.HasOne("library.Entities.Book", "Book")
                        .WithMany("GenreToBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("library.Entities.Genre", "Genre")
                        .WithMany("GenreToBooks")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("library.Entities.Author", b =>
                {
                    b.Navigation("AuthorToBooks");
                });

            modelBuilder.Entity("library.Entities.Book", b =>
                {
                    b.Navigation("AuthorToBooks");

                    b.Navigation("Editions");

                    b.Navigation("GenreToBooks");
                });

            modelBuilder.Entity("library.Entities.Genre", b =>
                {
                    b.Navigation("GenreToBooks");
                });

            modelBuilder.Entity("library.Entities.Publisher", b =>
                {
                    b.Navigation("Editions");
                });

            modelBuilder.Entity("library.Entities.Section", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("library.Entities.Status", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
