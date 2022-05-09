using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace library.Models
{
    public partial class db_userContext : DbContext
    {
        public db_userContext()
        {
        }

        public db_userContext(DbContextOptions<db_userContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bookmark> Bookmarks { get; set; }
        public virtual DbSet<BooksToBookmark> BooksToBookmarks { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=db_user_new;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
      
        
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Bookmark>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.BookmarkNameOfTheCompilation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bookmark_name of the compilation]]]");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookmarks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bookmarks_Users");
            });

            modelBuilder.Entity<BooksToBookmark>(entity =>
            {
                entity.HasKey(e => new { e.BookmarkId, e.BookId });

                entity.ToTable("Books_to_bookmarks");

                entity.Property(e => e.BookmarkId).HasColumnName("bookmark_id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.HasOne(d => d.Bookmark)
                    .WithMany(p => p.BooksToBookmarks)
                    .HasForeignKey(d => d.BookmarkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_to_bookmarks_Bookmarks");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.BookmarkId).HasColumnName("bookmark_id");

                entity.Property(e => e.RatingReaction)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("rating_reaction");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Bookmark)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.BookmarkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rating_Bookmarks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rating_User");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.ReviewMedia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("review_media");

                entity.Property(e => e.ReviewRating).HasColumnName("review_rating");

                entity.Property(e => e.ReviewText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("review_text");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reviews_Users");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CreatorId });

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.SubscriptionCreators)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscriptions_Users1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubscriptionUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscriptions_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_login");

                entity.Property(e => e.UserNickname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nickname");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_password")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }
       
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
