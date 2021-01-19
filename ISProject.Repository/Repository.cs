using ISProject.DAL;
using ISProject.Repository.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ISProject.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj) => _dbSet.Add(obj);
        public IQueryable<TEntity> GetAll() => _dbSet.AsNoTracking();
        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression) => _dbSet.Where(expression);
        public virtual void Update(TEntity obj) => _dbSet.Update(obj);
        public virtual void Remove<T>(T id) => _dbSet.Remove(_dbSet.Find(id));
        public void Remove(TEntity obj) => _dbSet.Remove(obj);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
