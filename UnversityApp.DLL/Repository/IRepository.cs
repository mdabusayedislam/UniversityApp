using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnversityApp.DLL.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> QueryAll(Expression<Func<T, bool>> expression = null);
        Task CreateAsync(T entity);
        Task CreateAsync(List<T> entity);
        void UpdateAsync(T entity);
        void UpdateAsync(List<T> entity);
        void DeleteAsync(T entity);
        void DeleteAsync(List<T> entity);
        Task<T> FileSingleAsync(Expression<Func<T, bool>> expression);
    }

}