using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlazorProvider.Provider
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindList(Expression<Func<T, bool>> expression);
        T FindById(Expression<Func<T, bool>> expression);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save();
    }
}
