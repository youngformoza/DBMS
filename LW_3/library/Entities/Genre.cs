using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Genre : BaseEntity
    {
        public Genre()
        {
            GenreToBooks = new HashSet<GenreToBook>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<GenreToBook> GenreToBooks { get; set; }
    }
}
