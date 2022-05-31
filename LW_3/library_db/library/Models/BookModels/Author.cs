using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Models.BookModels
{
    [Table("authors")]
    public partial class Author : BaseEntity
    {
        public Author()
        {
            AuthorToBooks = new HashSet<AuthorToBook>();
        }

        [Column("author_fullname")]
        public string AuthorFullname { get; set; }
        [Column("author_country")]
        public string AuthorCountry { get; set; }

        public virtual ICollection<AuthorToBook> AuthorToBooks { get; set; }
    }
}
