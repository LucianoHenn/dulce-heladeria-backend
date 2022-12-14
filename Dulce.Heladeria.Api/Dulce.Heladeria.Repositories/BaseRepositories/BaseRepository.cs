
using Asofar.Backend.Models.Repositories;
using Dulce.Heladeria.DataAccess.Data;
using Dulce.Heladeria.Models.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dulce.Heladeria.Repositories.BaseRepositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>, IPersistable<TEntity> where TEntity : class, IBaseEntity
    {
        private readonly ApplicationDbContext _bd;
        protected DbSet<TEntity> DbSet => _bd.Set<TEntity>();
        protected virtual IQueryable<TEntity> BaseQuery => DbSet;
        public BaseRepository(ApplicationDbContext bd)
        {
            _bd=bd;
        }

        public virtual IEnumerable<TEntity> GetAll() => BaseQuery.Where(x => x.DeletionDate == null).ToList();
        public virtual TEntity GetById(Int32 id) => BaseQuery.Where(x => x.Id == id).FirstOrDefault();
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, Boolean>> predicate) => BaseQuery.Where(predicate).ToList();
        public virtual async Task InsertAsync(TEntity entity) => await DbSet.AddAsync(entity);
        public virtual async Task UpdateAsync(TEntity entityToUpdate) => await Task.Run(() => { DbSet.Update(entityToUpdate); });
        public virtual async Task DeleteAsync(TEntity entityToDelete) => await Task.Run(() => { DbSet.Remove(entityToDelete); });
        public async Task<Int32> SaveAsync(TEntity entity)
        {
            DbSet.Add(entity);
            await _bd.SaveChangesAsync();
            return entity.Id;
        }


    }
}
