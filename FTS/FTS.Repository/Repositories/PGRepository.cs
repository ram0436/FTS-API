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
    public class PGRepository : GenericRepository<PG>, IPGRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<PG> _dbSet;
        public PGRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<PG>();
        }
        public PGRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<PG>();
        }
    }
}
