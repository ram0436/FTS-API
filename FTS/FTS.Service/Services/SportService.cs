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
    public class SportService : ISportService
    {
        ISportRepository _sportRepository ;
        public SportService(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }
        public IEnumerable<Sports> GetAll()
        {
            return _sportRepository.GetAll();
        }
        public Sports GetById(long id)
        {
            return _sportRepository.GetById(id);
        }
        public void Insert(Sports sport)
        {
            _sportRepository.Insert(sport);
        }
        public void Update(Sports sport)
        {
            _sportRepository.Update(sport);
        }

        public void Delete(long id)
        {
            _sportRepository.Delete(id);
        }
    }
}
