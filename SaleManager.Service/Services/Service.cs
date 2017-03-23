using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaleManager.Data.Models;
using System.Data.Entity;
namespace SaleManager.Service.Services
{
    public abstract class Service<T> : IService<T> where T : class
    {
        internal SaleManagementContext _context;
        internal DbSet<T> _dbSet;

        public Service(SaleManagementContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }
        
        public T Find(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Create(T entity)
        {
            _dbSet.Add(entity);
       }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }  
    }
}
