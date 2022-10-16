using System;
using System.Collections.Generic;
using System.Text;

namespace Dulce.Heladeria.Models.BaseEntities
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
