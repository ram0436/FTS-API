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
    public class JobService : IJobService
    {
        IJobRepository _jobRepository ;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public IEnumerable<Jobs> GetAll()
        {
            return _jobRepository.GetAll();
        }
        public Jobs GetById(long userId)
        {
            return _jobRepository.GetById(userId);
        }
        public void Insert(Jobs user)
        {
            _jobRepository.Insert(user);
        }
        public void Update(Jobs user)
        {
            _jobRepository.Update(user);
        }

        public void Delete(long id)
        {
            _jobRepository.Delete(id);
        }
    }
}
