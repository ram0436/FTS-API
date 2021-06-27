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
        public Sports GetById(long userId)
        {
            return _sportRepository.GetById(userId);
        }
        public void Insert(Sports user)
        {
            _sportRepository.Insert(user);
        }
        public void Update(Sports user)
        {
            _sportRepository.Update(user);
        }

        public void Delete(long id)
        {
            _sportRepository.Delete(id);
        }
    }
}
