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
    public class FurnitureRepository : GenericRepository<Furnitures>, IFurnitureRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<Furnitures> _dbSet;
        public FurnitureRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<Furnitures>();
        }
        public FurnitureRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Furnitures>();
        }
    }
}
