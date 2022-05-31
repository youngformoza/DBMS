using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LibraryAPI.Models.UserModels
{
    public partial class Bookmark : BaseEntity
    {
        public Bookmark()
        {
            BooksToBookmarks = new HashSet<BooksToBookmark>();
            Ratings = new HashSet<Rating>();
        }

        [Column("bookmark_name of the compilation")]
        public string BookmarkNameOfTheCompilation { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }


        public virtual User User { get; set; }
        public virtual ICollection<BooksToBookmark> BooksToBookmarks { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
