using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Models.UserModels
{
    public partial class Rating : BaseEntity
    {

        [Column("rating_reaction")]
        public string RatingReaction { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("bookmark_id")]
        public int BookmarkId { get; set; }

        public virtual Bookmark Bookmark { get; set; }
        public virtual User User { get; set; }
    }
}
