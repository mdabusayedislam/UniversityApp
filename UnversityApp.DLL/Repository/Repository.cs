using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace UnversityApp.DLL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext db;
        protected readonly DbSet<T> dbSet;
        public Repository(ApplicationDbContext context)
        {
            db = context;
            dbSet = db.Set<T>();
        }
        public IQueryable<T> QueryAll(Expression<Func<T, bool>> expression = null)
        {
            if (expression == null)
            {
                return dbSet.AsQueryable().AsTracking();
            }
            return dbSet.AsQueryable().Where(expression).AsNoTracking();
        }
        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }
        public async Task CreateAsync(List<T> entity)
        {
            await dbSet.AddRangeAsync(entity);
        }
        public void UpdateAsync(T entity)
        {
            dbSet.Update(entity);
        }
        public void UpdateAsync(List<T> entity)
        {
            dbSet.UpdateRange(entity);
        }
        public void DeleteAsync(T entity)
        {
            dbSet.Remove(entity);
        }
        public void DeleteAsync(List<T> entity)
        {
            dbSet.RemoveRange(entity);
        }       
        public async Task<T> FileSingleAsync(Expression<Func<T, bool>> expression)
        {
           return await dbSet.FirstOrDefaultAsync(expression);
        }
        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(obj: this);

        }


    }

}