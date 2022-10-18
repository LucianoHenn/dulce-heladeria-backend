using Dulce.Heladeria.Repositories.BaseRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Dulce.Heladeria.Models.Entities;
using Dulce.Heladeria.Repositories.IRepositories;
using Dulce.Heladeria.DataAccess.Data;

namespace Dulce.Heladeria.Repositories.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ApplicationDbContext bd) : base(bd)
        {
        }
    }
}
