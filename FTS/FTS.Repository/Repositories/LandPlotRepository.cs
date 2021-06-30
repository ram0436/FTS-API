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
    public class LandPlotRepository : GenericRepository<LandPlots>, ILandPlotRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<LandPlots> _dbSet;
        public LandPlotRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<LandPlots>();
        }
        public LandPlotRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<LandPlots>();
        }
    }
}
