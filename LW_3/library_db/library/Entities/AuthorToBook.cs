using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities 
{
    [Table("authors_to_books")]
    public partial class AuthorToBook : BaseEntity
    {
        [Column("author_id")]
        public int AuthorId { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
  
    } 
}
