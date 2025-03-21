using System.Linq.Expressions;

namespace TodoAppNTier.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(object id);

        Task<T> GetByFilter(Expression<Func<T,bool>> filter, bool asNoTracking = false  );

        Task Create(T entity);
        void Update(T entity);
        void Remove(T entity);

        IQueryable<T> GetQuery();

    }
}
