using library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Models
{
    public partial class BooksToBookmark : BaseEntity
    {
        [Column("bookmark_id")]
        public int BookmarkId { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }

        public virtual Bookmark Bookmark { get; set; }
    }
}
