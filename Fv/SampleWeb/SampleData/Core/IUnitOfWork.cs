using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Core
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        void Save();
        Task SaveAsync();
    }
}
