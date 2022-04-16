using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Book : BaseEntity
    {
        public Book()
        {
            AuthorToBooks = new HashSet<AuthorToBook>();
            Editions = new HashSet<Edition>();
            GenreToBooks = new HashSet<GenreToBook>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public int? BookCount { get; set; }
        public string BookDescription { get; set; }
        public int? BookAgeRestriction { get; set; }
        public int? BookmarkId { get; set; }
        public int? RatingId { get; set; }
        public int StatusId { get; set; }
        public int SectionId { get; set; }

        public virtual Section Section { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<AuthorToBook> AuthorToBooks { get; set; }
        public virtual ICollection<Edition> Editions { get; set; }
        public virtual ICollection<GenreToBook> GenreToBooks { get; set; }
    }
}
