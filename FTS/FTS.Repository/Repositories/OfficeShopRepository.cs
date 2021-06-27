using FTS.Model.DbContexts;
using FTS.Model.Entities;
using FTS.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Repository.Repositories
{
    public class OfficeShopRepository : GenericRepository<OfficeShops>, IOfficeShopRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<OfficeShops> _dbSet;
        private bool disposedValue = false;
        public OfficeShopRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<OfficeShops>();
        }
        public OfficeShopRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<OfficeShops>();
        }

        public new void Dispose()
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
