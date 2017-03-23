using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaleManager.Service.Services
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Find(object id);
        void Create(T entity);
        void Update(T entity);
        void Delete(object id);
        void Delete(T entity);
    }
}
