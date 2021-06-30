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
        public Jobs GetById(long id)
        {
            return _jobRepository.GetById(id);
        }
        public void Insert(Jobs job)
        {
            _jobRepository.Insert(job);
        }
        public void Update(Jobs job)
        {
            _jobRepository.Update(job);
        }

        public void Delete(long id)
        {
            _jobRepository.Delete(id);
        }
    }
}
