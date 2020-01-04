using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Core
{
    public abstract class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        protected readonly TContext _dbContext;

        protected UnitOfWork(string connectionString,string migrationAssemblyName)
        {
            _dbContext = (TContext)Activator.CreateInstance(typeof(TContext), connectionString, migrationAssemblyName);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
