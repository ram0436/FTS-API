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
    public class UserRepository : GenericRepository<Users>, IUserRepository, IDisposable
    {
        private new readonly FTSDbContext _dbContext = null;
        protected new DbSet<Users> _dbSet;
        public UserRepository()
        {
            _dbContext = new FTSDbContext();
            _dbSet = _dbContext.Set<Users>();
        }
        public UserRepository(FTSDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Users>();
        }

        // This methode has called by store procedure
        //public new  Users GetById(long id)
        //{
        //    return _dbContext.Users.FromSqlRaw<Users>("uspGetUserById {0}",id).ToList().FirstOrDefault();
        //}
    }
}
