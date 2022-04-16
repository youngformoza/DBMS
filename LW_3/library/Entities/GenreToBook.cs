using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class GenreToBook : BaseEntity
    {
        public int GenreId { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
