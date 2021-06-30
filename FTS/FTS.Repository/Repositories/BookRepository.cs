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
    public class BookRepository : GenericRepository<Books>, IBookRepository
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<Books> _dbSet;
        public BookRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<Books>();
        }
        public BookRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Books>();
        }
    }
}
