using FTS.Model.Entities;
using FTS.Repository.IRepositories;
using FTS.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.Services
{
    public class PGService : IPGService
    {
        IPGRepository _pgRepository ;
        public PGService(IPGRepository pgRepository)
        {
            _pgRepository = pgRepository;
        }
        public IEnumerable<PG> GetAll()
        {
            return _pgRepository.GetAll();
        }
        public PG GetById(long id)
        {
            return _pgRepository.GetById(id);
        }
        public void Insert(PG pg)
        {
            _pgRepository.Insert(pg);
        }
        public void Update(PG pg)
        {
            _pgRepository.Update(pg);
        }

        public void Delete(long id)
        {
            _pgRepository.Delete(id);
        }
    }
}
