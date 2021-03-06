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
    public class PetRepository : GenericRepository<Pets>, IPetRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<Pets> _dbSet;
        public PetRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<Pets>();
        }
        public PetRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Pets>();
        }
    }
}
