
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Challenge13CodeFirst.Datos;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Challenge13CodeFirst.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class

    {
        internal ApplicationDbContext _dbcontext;

        //private readonly ApplicationDbContext _dbContext;
        public GenericRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add(T entity)
        {
            _dbcontext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _dbcontext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        }

        public void Delete(T entity)
        {
            _dbcontext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _dbcontext.Set<T>();
            return query;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _dbcontext.Set<T>().Where(predicate);
            return query;
        }

        public void save()
        {
            _dbcontext.SaveChanges();
        }
      
    }
}