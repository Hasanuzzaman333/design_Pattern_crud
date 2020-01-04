using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivaTest.Web.Core.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveAsync();
        void Save();
    }
}
