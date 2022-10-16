using System;
using System.Threading.Tasks;

namespace Asofar.Backend.Models.Repositories
{
    public interface IPersistable<TEntity>
    {
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entityToUpdate);
        Task DeleteAsync(TEntity entityToDelete);

        Task<Int32> SaveAsync(TEntity entity);
    }
}
