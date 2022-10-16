
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dulce.Heladeria.Models.BaseEntities
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
