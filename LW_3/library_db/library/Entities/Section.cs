using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Entities
{
    [Table("sections")] 
    public partial class Section : BaseEntity
    {
        public Section()
        {
            Books = new HashSet<Book>();
        }

        [Column("section_name")]
        public string SectionName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
