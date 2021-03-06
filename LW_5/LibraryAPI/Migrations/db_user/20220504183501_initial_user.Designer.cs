// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using LibraryAPI.Models;
using LibraryAPI.ApplicationContexts;

namespace LibraryAPI.Migrations.db_user
{
    [DbContext(typeof(DbUserContext))]
    [Migration("20220504183501_initial_user")]
    partial class initial_user
    {

        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("library.Models.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookmarkNameOfTheCompilation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("bookmark_name of the compilation]]]");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("library.Models.BooksToBookmark", b =>
                {
                    b.Property<int>("BookmarkId")
                        .HasColumnType("int")
                        .HasColumnName("bookmark_id");

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.HasKey("BookmarkId", "BookId");

                    b.ToTable("Books_to_bookmarks");
                });

            modelBuilder.Entity("library.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookmarkId")
                        .HasColumnType("int")
                        .HasColumnName("bookmark_id");

                    b.Property<string>("RatingReaction")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("rating_reaction");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("BookmarkId");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("library.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<string>("ReviewMedia")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("review_media");

                    b.Property<int>("ReviewRating")
                        .HasColumnType("int")
                        .HasColumnName("review_rating");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("review_text");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("library.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role_name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("library.Models.Subscription", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int")
                        .HasColumnName("creator_id");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.HasKey("UserId", "CreatorId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("library.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_login");

                    b.Property<string>("UserNickname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_nickname");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasColumnName("user_password")
                        .IsFixedLength(true);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("library.Models.Bookmark", b =>
                {
                    b.HasOne("library.Models.User", "User")
                        .WithMany("Bookmarks")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Bookmarks_Users")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("library.Models.BooksToBookmark", b =>
                {
                    b.HasOne("library.Models.Bookmark", "Bookmark")
                        .WithMany("BooksToBookmarks")
                        .HasForeignKey("BookmarkId")
                        .HasConstraintName("FK_Books_to_bookmarks_Bookmarks")
                        .IsRequired();

                    b.Navigation("Bookmark");
                });

            modelBuilder.Entity("library.Models.Rating", b =>
                {
                    b.HasOne("library.Models.Bookmark", "Bookmark")
                        .WithMany("Ratings")
                        .HasForeignKey("BookmarkId")
                        .HasConstraintName("FK_Rating_Bookmarks")
                        .IsRequired();

                    b.HasOne("library.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Rating_User")
                        .IsRequired();

                    b.Navigation("Bookmark");

                    b.Navigation("User");
                });

            modelBuilder.Entity("library.Models.Review", b =>
                {
                    b.HasOne("library.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Reviews_Users")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("library.Models.Subscription", b =>
                {
                    b.HasOne("library.Models.User", "Creator")
                        .WithMany("SubscriptionCreators")
                        .HasForeignKey("CreatorId")
                        .HasConstraintName("FK_Subscriptions_Users1")
                        .IsRequired();

                    b.HasOne("library.Models.User", "User")
                        .WithMany("SubscriptionUsers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Subscriptions_Users")
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("library.Models.User", b =>
                {
                    b.HasOne("library.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_Users_Role")
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("library.Models.Bookmark", b =>
                {
                    b.Navigation("BooksToBookmarks");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("library.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("library.Models.User", b =>
                {
                    b.Navigation("Bookmarks");

                    b.Navigation("Ratings");

                    b.Navigation("Reviews");

                    b.Navigation("SubscriptionCreators");

                    b.Navigation("SubscriptionUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
