using Microsoft.EntityFrameworkCore;
using Serene.DataAccess.Data;
using Serene.DataAccess.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serene.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }
        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            IQueryable<T> query = dbSet;
            return await query.ToListAsync();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

    }
}
