using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LibraryAPI.Models.UserModels
{
    public partial class Subscription : BaseEntity
    {

        [Column("user_id")]
        public int UserId { get; set; }
        [Column("creator_id")]
        public int CreatorId { get; set; }


        public virtual User Creator { get; set; }
        public virtual User User { get; set; }


    }
}
