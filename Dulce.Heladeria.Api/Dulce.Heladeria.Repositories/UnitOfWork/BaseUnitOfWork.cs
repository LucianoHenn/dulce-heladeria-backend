using Dulce.Heladeria.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce.Heladeria.Models.UnitOfWork
{
    public class BaseUnitOfWork: IUnitOfWork
    {
        protected ApplicationDbContext Context { get; set; }
        public BaseUnitOfWork(ApplicationDbContext context)
        {
            Context = context;
        }
        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            Context.Database.CurrentTransaction?.Commit();
        }

        public async Task CommitAsync()
        {
            await Context.Database.CurrentTransaction?.CommitAsync();
        }

        public void Rollback()
        {
            var entries = Context.ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted);

            foreach (var entry in entries)
                entry.State = EntityState.Detached;

            Context.SaveChanges();
        }


        public Int32 SaveChanges()
        {
            return Context.SaveChanges();
        }

        public async Task<Int32> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
