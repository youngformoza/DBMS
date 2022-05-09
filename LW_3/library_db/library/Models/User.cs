using library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Models
{
    public partial class User : BaseEntity
    {
        public User()
        {
            Bookmarks = new HashSet<Bookmark>();
            Ratings = new HashSet<Rating>();
            Reviews = new HashSet<Review>();
            SubscriptionCreators = new HashSet<Subscription>();
            SubscriptionUsers = new HashSet<Subscription>();
        }

        [Column("user_nickname")]
        public string UserNickname { get; set; }
        [Column("user_login")]
        public string UserLogin { get; set; }
        [Column("user_password")]
        public string UserPassword { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }

        
        public virtual Role Role { get; set; }
        public virtual ICollection<Bookmark> Bookmarks { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Subscription> SubscriptionCreators { get; set; }
        public virtual ICollection<Subscription> SubscriptionUsers { get; set; }
        
    }
}
