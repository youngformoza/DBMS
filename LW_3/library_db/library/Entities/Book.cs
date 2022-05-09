using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities
{
    [Table("books")]
    public partial class Book : BaseEntity
    {
        public Book()
        {
            AuthorToBooks = new HashSet<AuthorToBook>();
            Editions = new HashSet<Edition>();
            GenreToBooks = new HashSet<GenreToBook>();
        }

        [Column("book_name")]
        public string BookName { get; set; }
        [Column("book_count")]
        public int? BookCount { get; set; }
        [Column("book_description")]
        public string BookDescription { get; set; }
        [Column("book_age_restriction")]
        public int? BookAgeRestriction { get; set; }
        [Column("bookmark_id")]
        public int? BookmarkId { get; set; }
        [Column("rating_id")]
        public int? RatingId { get; set; }
        [Column("status_id")]
        public int StatusId { get; set; }
        [Column("section_id")]
        public int SectionId { get; set; }

        public virtual Section Section { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<AuthorToBook> AuthorToBooks { get; set; }
        public virtual ICollection<Edition> Editions { get; set; }
        public virtual ICollection<GenreToBook> GenreToBooks { get; set; }
    }
}
