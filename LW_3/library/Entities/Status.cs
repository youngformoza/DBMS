using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Status : BaseEntity
    {
        public Status()
        {
            Books = new HashSet<Book>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
