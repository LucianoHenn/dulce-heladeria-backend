using Dulce.Heladeria.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dulce.Heladeria.Services.Manager
{
    public class ItemManager
    {
        private readonly ApplicationDbContext _bd;
        public ItemManager(ApplicationDbContext bd)
        {
            _bd = bd;
        }

    }
}
