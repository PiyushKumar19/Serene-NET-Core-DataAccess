using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Serene.DataAccess.Repository.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Create(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
