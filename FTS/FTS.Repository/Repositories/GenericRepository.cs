using FTS.Model.DbContexts;
using FTS.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Repository.Repositories
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        protected FTSDbContext _dbContext = null;
        protected DbSet<T> _dbSet;
        private bool disposedValue = false;
        public GenericRepository()
        {
            this._dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<T>();
        }
        public GenericRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<T>();
            
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(long id)
        {
            return _dbSet.Find(id);
        }
        public void Insert(T obj)
        {
            _dbSet.Add(obj);
            Save();
        }
        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
            Save();
        }
        public void Delete(long id)
        {
            T existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            if (!disposedValue)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                }
                disposedValue = true;
            }
        }
    }
}
