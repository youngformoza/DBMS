using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LibraryAPI.Models.UserModels
{
    public partial class Review : BaseEntity
    {

        [Column("review_rating")]
        public int ReviewRating { get; set; }
        [Column("review_text")]
        public string ReviewText { get; set; }
        [Column("review_media")]
        public string ReviewMedia { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
