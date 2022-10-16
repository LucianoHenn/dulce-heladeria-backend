
using Asofar.Backend.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Dulce.Heladeria.Models.Entities;

namespace Dulce.Heladeria.Repositories.IRepositories
{
    public interface IUserRepository : IBaseRepository<UserEntity>, IPersistable<UserEntity>
    {
    }
}
