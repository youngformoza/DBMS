using library.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Author : BaseEntity
    {
        public Author()
        {
            AuthorToBooks = new HashSet<AuthorToBook>();
        }

        public int AuthorId { get; set; }
        public string AuthorFullname { get; set; }
        public string AuthorCountry { get; set; }

        public virtual ICollection<AuthorToBook> AuthorToBooks { get; set; }
    }
}
