using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities
{
    [Table("statuses")]
    public partial class Status : BaseEntity
    {
        public Status()
        {
            Books = new HashSet<Book>();
        }

        [Column("status_name")]
        public string StatusName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
