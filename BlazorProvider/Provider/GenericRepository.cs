using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlazorProvider.Provider
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T: class 
    {

        protected readonly DbContext _context;
        protected readonly DbSet<T> _entity;

        public GenericRepository(DbContext context )
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }

        public IEnumerable<T> FindList(Expression<Func<T, bool>> expression)
        {
            return _entity.Where(expression);
        }

        public T FindById(Expression<Func<T, bool>> expression)
        {
            return _entity.SingleOrDefault(expression);
        }

        public void Add(T entity)
        {
            _entity.Add(entity);

        }

        public void Delete(T entity)
        {
            _entity.Remove(entity);

        }

        public void Update(T entity)
        {
            _entity.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
      
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        private readonly DbContext context;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~GenericRepository()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion

    }
}
