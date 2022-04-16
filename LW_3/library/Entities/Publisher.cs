using System;
using System.Collections.Generic;

#nullable disable

namespace library.Entities
{
    public partial class Publisher : BaseEntity
    {
        public Publisher()
        {
            Editions = new HashSet<Edition>();
        }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

        public virtual ICollection<Edition> Editions { get; set; }
    }
}
