﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using LibraryAPI;
using LibraryAPI.ApplicationContexts;

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(DbLibraryContext))]
    [Migration("20220418185850_180422_2200")]
    partial class _180422_2200
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorCountry")
                        .HasColumnType("text");

                    b.Property<string>("AuthorFullname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("library.Entities.AuthorToBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("AuthorToBooks");
                });

            modelBuilder.Entity("library.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BookAgeRestriction")
                        .HasColumnType("integer");

                    b.Property<int?>("BookCount")
                        .HasColumnType("integer");

                    b.Property<string>("BookDescription")
                        .HasColumnType("text");

                    b.Property<string>("BookName")
                        .HasColumnType("text");

                    b.Property<int?>("BookmarkId")
                        .HasColumnType("integer");

                    b.Property<int?>("RatingId")
                        .HasColumnType("integer");

                    b.Property<int>("SectionId")
                        .HasColumnType("integer");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("StatusId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("library.Entities.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<string>("EditionIsbn")
                        .HasColumnType("text");

                    b.Property<int?>("EditionLength")
                        .HasColumnType("integer");

                    b.Property<int>("EditionNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("EditionPublication")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EditionType")
                        .HasColumnType("text");

                    b.Property<int>("PublisherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("library.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("library.Entities.GenreToBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("GenreToBooks");
                });

            modelBuilder.Entity("library.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("PublisherName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("library.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("SectionName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("library.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
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
