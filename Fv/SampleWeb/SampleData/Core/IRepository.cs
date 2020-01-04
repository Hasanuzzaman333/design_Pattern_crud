using SampleData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Core
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Remove(object id);

        void Remove(T entityToDelete);

        void Remove(Expression<Func<T, bool>> filter);

        Task RemoveAsync(Guid id);
        Task RemoveAsync(T entityToDelete);

        void Edit(T entityToUpdate);
        Task EditAsync(T entityToUpdate);
        int GetCount(Expression<Func<T, bool>> filter = null);

        IEnumerable<T> Get(
            out int total, out int totalDisplay,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        //Task<PagedData<T>> GetPagedAsync(
        //    Expression<Func<T, bool>> filter = null,
        //    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //    string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        PagedData<T> GetPaged(
           Expression<Func<T, bool>> filter = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>,
          IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool isTrackingOff = false);
    }
}
