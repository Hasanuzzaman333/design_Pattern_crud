using Microsoft.EntityFrameworkCore;
using SampleData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleData.Core
{
    public abstract class Repository<T> : IRepository<T> where T :class
    {
        protected DbContext context;
        protected DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            this.context = context;
            this.context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.dbSet = context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Remove(object id)
        {
            T entityToDelete = dbSet.Find(id);
            Remove(entityToDelete);
        }

        public virtual void Remove(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Remove(Expression<Func<T, bool>> filter)
        {
            dbSet.RemoveRange(dbSet.Where(filter));
        }

        public virtual async Task RemoveAsync(Guid id)
        {
            var entityToDelete = dbSet.Find(id);
            await RemoveAsync(entityToDelete);
        }
        public virtual async Task RemoveAsync(T entityToDelete)
        {
            await Task.Run(() =>
            {
                if (context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);
            });
        }

        public virtual void Edit(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
        public virtual async Task EditAsync(T entityToUpdate)
        {
            await Task.Run(() =>
            {
                //dbSet.Attach(entityToUpdate);
                context.Entry(entityToUpdate).State = EntityState.Modified;
            });
        }
        public virtual int GetCount(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = dbSet;
            int count = 0;

            if (filter != null)
            {
                query = query.Where(filter);
                count = query.Count();
            }
            else
                count = query.Count();

            return count;
        }

        public virtual IEnumerable<T> Get(
            out int total, out int totalDisplay,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            IQueryable<T> query = dbSet;
            total = query.Count();
            totalDisplay = query.Count();

            if (filter != null)
            {
                query = query.Where(filter);
                totalDisplay = query.Count();
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                var result = orderBy(query).Skip((pageIndex - 1) * pageSize).Take(pageSize);

                if (isTrackingOff)
                    return result.AsNoTracking().ToList();
                else
                    return result.ToList();
            }
            else
            {
                var result = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

                if (isTrackingOff)
                    return result.AsNoTracking().ToList();
                else
                    return result.ToList();
            }
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           string includeProperties = "", bool isTrackingOff = false)
        {
            IQueryable<T> query = dbSet;


            if (filter != null)
            {
                query = query.Where(filter);

            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                var result = orderBy(query);

                if (isTrackingOff)
                    return result.AsNoTracking().ToList();
                else
                    return result.ToList();
            }
            else
            {

                if (isTrackingOff)
                    return query.AsNoTracking().ToList();
                else
                    return query.ToList();
            }
        }

        public virtual PagedData<T> GetPaged(
           Expression<Func<T, bool>> filter = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            IQueryable<T> query = dbSet;
            var total = query.Count();
            var totalDisplay = query.Count();

            if (filter != null)
            {
                query = query.Where(filter);
                totalDisplay = query.Count();
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                var result = orderBy(query).Skip((pageIndex - 1) * pageSize).Take(pageSize);
                if (isTrackingOff)
                    return new PagedData<T>(result.AsNoTracking().ToList(), total, totalDisplay);
                else
                    return new PagedData<T>(result.ToList(), total, totalDisplay);
            }
            else
            {
                var result = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
                if (isTrackingOff)
                    return new PagedData<T>(result.AsNoTracking().ToList(), total, totalDisplay);
                else
                    return new PagedData<T>(result.ToList(), total, totalDisplay);
            }
        }
        //-------------//
        public virtual T GetByID(object id, string includeProperties = "")
        {
            if (string.IsNullOrEmpty(includeProperties))
                return context.Set<T>().Find(id);
            else
            {
                IQueryable<T> query = context.Set<T>();
                //query = query.Where(x => x.ID == (Guid)id);

                foreach (var includeProperty in includeProperties.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

                return query.SingleOrDefault();
            }
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>,
           IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool isTrackingOff = false)
        {
            IQueryable<T> query = context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                if (isTrackingOff)
                    return orderBy(query).AsNoTracking().ToList();
                else
                    return orderBy(query).ToList();
            }
            else
            {
                if (isTrackingOff)
                    return query.AsNoTracking().ToList();
                else
                    return query.ToList();
            }
        }

        
    }
}
