using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities
{
    [Table("publishers")]
    public partial class Publisher : BaseEntity
    {
        public Publisher()
        {
            Editions = new HashSet<Edition>();
        }

        [Column("publisher_name")]
        public string PublisherName { get; set; }

        public virtual ICollection<Edition> Editions { get; set; }
    }
}
