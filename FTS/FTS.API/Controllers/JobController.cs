using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {

        private IJobService _jobService ;
        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public IEnumerable<Jobs> GetAll()
        {
            return _jobService.GetAll();
        }

        [HttpGet("{id}")]
        public Jobs GetById(long id)
        {
            return _jobService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Jobs job)
        {
            _jobService.Insert(job);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Jobs job)
        {
            _jobService.Update(job);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _jobService.Delete(id);
        }
    }
}
