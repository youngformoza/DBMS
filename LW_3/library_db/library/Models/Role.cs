using library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace library.Models
{
    public partial class Role : BaseEntity
    {
        public Role()
        {
            Users = new HashSet<User>();
        }


        [Column("role_name")]
        public string RoleName { get; set; }

       public virtual ICollection<User> Users { get; set; }
    }
}
