using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Edition : BaseEntity
    {
        public int EditionId { get; set; }
        public string EditionIsbn { get; set; }
        public int EditionNumber { get; set; }
        public DateTime? EditionPublication { get; set; }
        public int? EditionLength { get; set; }
        public string EditionType { get; set; }
        public int PublisherId { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
