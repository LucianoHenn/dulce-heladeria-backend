using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dulce.Heladeria.Models.UnitOfWork
{
    public interface IUnitOfWork
    {
        IDbContextTransaction BeginTransaction();
        int SaveChanges();
        Task<int> SaveChangesAsync();

        void Commit();
        void Rollback();
        Task CommitAsync();
    }
}
