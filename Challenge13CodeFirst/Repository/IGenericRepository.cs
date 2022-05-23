using System.Linq.Expressions;

namespace Challenge13CodeFirst.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Find (Expression<Func<T, bool >> predicate);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void save();
    }
}
