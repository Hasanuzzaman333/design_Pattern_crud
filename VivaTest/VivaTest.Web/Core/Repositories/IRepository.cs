using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VivaTest.Web.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
