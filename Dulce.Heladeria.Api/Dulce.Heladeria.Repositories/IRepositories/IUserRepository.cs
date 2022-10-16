
using Asofar.Backend.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dulce.Heladeria.Repositories.IRepositories
{
    internal interface IUserRepository : IBaseRepository<UserEntity>, IPersistable<UserEntity>
    {
    }
}
