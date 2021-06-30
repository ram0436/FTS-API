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
    public class HobbyRepository : GenericRepository<Hobbies>, IHobbyRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<Hobbies> _dbSet;
        public HobbyRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<Hobbies>();
        }
        public HobbyRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Hobbies>();
        }
    }
}
