using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Section : BaseEntity
    {
        public Section()
        {
            Books = new HashSet<Book>();
        }

        public int SectionId { get; set; }
        public string SectionName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
