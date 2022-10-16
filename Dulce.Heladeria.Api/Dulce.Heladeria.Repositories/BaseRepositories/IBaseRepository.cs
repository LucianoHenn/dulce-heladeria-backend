using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Asofar.Backend.Models.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        TEntity GetById(Int32 id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, Boolean>> predicate);

    }
}
