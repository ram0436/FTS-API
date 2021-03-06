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
    public class CommercialServiceRepository : GenericRepository<CommercialServices>, ICommercialServiceRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<CommercialServices> _dbSet;
        public CommercialServiceRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<CommercialServices>();
        }
        public CommercialServiceRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<CommercialServices>();
        }
    }
}
