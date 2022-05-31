using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Models.BookModels
{
    [Table("editions")]
    public partial class Edition : BaseEntity
    {
        [Column("edition_ISBN")]
        public string EditionIsbn { get; set; }

        [Column("edition_number")]
        public int EditionNumber { get; set; }

        [Column("edition_publication")]
        public DateTime? EditionPublication { get; set; }

        [Column("edition_length")]
        public int? EditionLength { get; set; }

        [Column("edition_type")]
        public string EditionType { get; set; }

        [Column("publisher_id")]
        public int PublisherId { get; set; }

        [Column("book_id")]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
