using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportController : ControllerBase
    {

        private ISportService _sportService ;
        public SportController(ISportService sportService)
        {
            _sportService = sportService;
        }

        [HttpGet]
        public IEnumerable<Sports> GetAll()
        {
            return _sportService.GetAll();
        }

        [HttpGet("{id}")]
        public Sports GetById(long id)
        {
            return _sportService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Sports sport)
        {
            _sportService.Insert(sport);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Sports sport)
        {
            _sportService.Update(sport);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _sportService.Delete(id);
        }
    }
}
