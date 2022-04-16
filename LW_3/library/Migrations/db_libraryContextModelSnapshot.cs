﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using library;

namespace library.Migrations
{
    [DbContext(typeof(db_libraryContext))]
    partial class db_libraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Russian_Russia.1251")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("library.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorCountry")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("author_country");

                    b.Property<string>("AuthorFullname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("author_fullname");

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.HasKey("Id");

                    b.ToTable("author", "sch_library");
                });

            modelBuilder.Entity("library.Entities.AuthorToBook", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("integer")
                        .HasColumnName("author_id");

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("AuthorId", "BookId")
                        .HasName("author_to_book_pkey");

                    b.HasIndex("BookId");

                    b.ToTable("author_to_book", "sch_library");
                });

            modelBuilder.Entity("library.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BookAgeRestriction")
                        .HasColumnType("integer")
                        .HasColumnName("book_age_restriction");

                    b.Property<int?>("BookCount")
                        .HasColumnType("integer")
                        .HasColumnName("book_count");

                    b.Property<string>("BookDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("book_description");

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
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

                    b.ToTable("book", "sch_library");
                });

            modelBuilder.Entity("library.Entities.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<int>("EditionId")
                        .HasColumnType("integer")
                        .HasColumnName("edition_id");

                    b.Property<string>("EditionIsbn")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)")
                        .HasColumnName("edition_isbn");

                    b.Property<int?>("EditionLength")
                        .HasColumnType("integer")
                        .HasColumnName("edition_length");

                    b.Property<int>("EditionNumber")
                        .HasColumnType("integer")
                        .HasColumnName("edition_number");

                    b.Property<DateTime?>("EditionPublication")
                        .HasColumnType("date")
                        .HasColumnName("edition_publication");

                    b.Property<string>("EditionType")
                        .HasMaxLength(4)
                        .HasColumnType("character varying(4)")
                        .HasColumnName("edition_type");

                    b.Property<int>("PublisherId")
                        .HasColumnType("integer")
                        .HasColumnName("publisher_id");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("edition", "sch_library");
                });

            modelBuilder.Entity("library.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("GenreId")
                        .HasColumnType("integer")
                        .HasColumnName("genre_id");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("genre_name");

                    b.HasKey("Id");

                    b.ToTable("genre", "sch_library");
                });

            modelBuilder.Entity("library.Entities.GenreToBook", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("integer")
                        .HasColumnName("genre_id");

                    b.Property<int>("BookId")
                        .HasColumnType("integer")
                        .HasColumnName("book_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("GenreId", "BookId")
                        .HasName("genre_to_book_pkey");

                    b.HasIndex("BookId");

                    b.ToTable("genre_to_book", "sch_library");
                });

            modelBuilder.Entity("library.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("PublisherId")
                        .HasColumnType("integer")
                        .HasColumnName("publisher_id");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("publisher_name");

                    b.HasKey("Id");

                    b.ToTable("publisher", "sch_library");
                });

            modelBuilder.Entity("library.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("SectionId")
                        .HasColumnType("integer")
                        .HasColumnName("section_id");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("section_name");

                    b.HasKey("Id");

                    b.ToTable("section", "sch_library");
                });

            modelBuilder.Entity("library.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("status_id");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("status_name");

                    b.HasKey("Id");

                    b.ToTable("status", "sch_library");
                });

            modelBuilder.Entity("library.Entities.AuthorToBook", b =>
                {
                    b.HasOne("library.Entities.Author", "Author")
                        .WithMany("AuthorToBooks")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("author_to_book_author_id_fkey")
                        .IsRequired();

                    b.HasOne("library.Entities.Book", "Book")
                        .WithMany("AuthorToBooks")
                        .HasForeignKey("BookId")
                        .HasConstraintName("author_to_book_book_id_fkey")
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("library.Entities.Book", b =>
                {
                    b.HasOne("library.Entities.Section", "Section")
                        .WithMany("Books")
                        .HasForeignKey("SectionId")
                        .HasConstraintName("book_section_id_fkey")
                        .IsRequired();

                    b.HasOne("library.Entities.Status", "Status")
                        .WithMany("Books")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("book_status_id_fkey")
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("library.Entities.Edition", b =>
                {
                    b.HasOne("library.Entities.Book", "Book")
                        .WithMany("Editions")
                        .HasForeignKey("BookId")
                        .HasConstraintName("edition_book_id_fkey")
                        .IsRequired();

                    b.HasOne("library.Entities.Publisher", "Publisher")
                        .WithMany("Editions")
                        .HasForeignKey("PublisherId")
                        .HasConstraintName("edition_publisher_id_fkey")
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("library.Entities.GenreToBook", b =>
                {
                    b.HasOne("library.Entities.Book", "Book")
                        .WithMany("GenreToBooks")
                        .HasForeignKey("BookId")
                        .HasConstraintName("genre_to_book_book_id_fkey")
                        .IsRequired();

                    b.HasOne("library.Entities.Genre", "Genre")
                        .WithMany("GenreToBooks")
                        .HasForeignKey("GenreId")
                        .HasConstraintName("genre_to_book_genre_id_fkey")
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
