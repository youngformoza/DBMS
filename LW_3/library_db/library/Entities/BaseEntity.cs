using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Entities
{
    public abstract class BaseEntity : IEntity
    {
        [Column("Id")]
        public int Id { get; set; }
    }
}
