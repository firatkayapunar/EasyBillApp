using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Abstract.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EasyBill.DataAccess.Repositories.Concrete.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EasyBillDBContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(EasyBillDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
