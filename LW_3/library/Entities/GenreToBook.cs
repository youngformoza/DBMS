using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities
{
    [Table("genres_to_books")]
    public partial class GenreToBook : BaseEntity
    {
        [Column("genre_id")]
        public int GenreId { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
