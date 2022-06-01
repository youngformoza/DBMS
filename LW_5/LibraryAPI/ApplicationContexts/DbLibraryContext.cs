using System;
using LibraryAPI.Models.BookModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LibraryAPI.ApplicationContexts
{
    public partial class DbLibraryContext : DbContext
    {

        public DbLibraryContext(DbContextOptions<DbLibraryContext> options)
            : base(options)
        {
        }

        public DbLibraryContext()
        {
                
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<AuthorToBook> AuthorToBooks { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Edition> Editions { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<GenreToBook> GenreToBooks { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

       
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("author", "sch_library");

                entity.Property(e => e.Id).HasColumnName("author_id");

                entity.Property(e => e.AuthorCountry)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("author_country");

                entity.Property(e => e.AuthorFullname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("author_fullname");
            });

            modelBuilder.Entity<AuthorToBook>(entity =>
            {
                entity.HasKey(e => new { e.AuthorId, e.BookId })
                    .HasName("author_to_book_pkey");

                entity.ToTable("author_to_book", "sch_library");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.AuthorToBooks)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("author_to_book_author_id_fkey");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.AuthorToBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("author_to_book_book_id_fkey");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book", "sch_library");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.BookAgeRestriction).HasColumnName("book_age_restriction");

                entity.Property(e => e.BookCount).HasColumnName("book_count");

                entity.Property(e => e.BookDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("book_description");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("book_name");

                entity.Property(e => e.BookmarkId).HasColumnName("bookmark_id");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("book_section_id_fkey");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("book_status_id_fkey");
            });

            modelBuilder.Entity<Edition>(entity =>
            {
                entity.ToTable("edition", "sch_library");

                entity.Property(e => e.EditionId).HasColumnName("edition_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.EditionIsbn)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("edition_isbn");

                entity.Property(e => e.EditionLength).HasColumnName("edition_length");

                entity.Property(e => e.EditionNumber).HasColumnName("edition_number");

                entity.Property(e => e.EditionPublication)
                    .HasColumnType("date")
                    .HasColumnName("edition_publication");

                entity.Property(e => e.EditionType)
                    .HasMaxLength(4)
                    .HasColumnName("edition_type");

                entity.Property(e => e.PublisherId).HasColumnName("publisher_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Editions)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("edition_book_id_fkey");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Editions)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("edition_publisher_id_fkey");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre", "sch_library");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("genre_name");
            });

            modelBuilder.Entity<GenreToBook>(entity =>
            {
                entity.HasKey(e => new { e.GenreId, e.BookId })
                    .HasName("genre_to_book_pkey");

                entity.ToTable("genre_to_book", "sch_library");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.GenreToBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("genre_to_book_book_id_fkey");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.GenreToBooks)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("genre_to_book_genre_id_fkey");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("publisher", "sch_library");

                entity.Property(e => e.PublisherId).HasColumnName("publisher_id");

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("publisher_name");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("section", "sch_library");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("section_name");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status", "sch_library");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("status_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }*/

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}