using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities
{
    [Table("genres")]
    public partial class Genre : BaseEntity
    {
        public Genre()
        {
            GenreToBooks = new HashSet<GenreToBook>();
        }

        [Column("genre_name")]
        public string GenreName { get; set; }

        public virtual ICollection<GenreToBook> GenreToBooks { get; set; }
    }
}
