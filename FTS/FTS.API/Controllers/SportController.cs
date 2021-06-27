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
        public void Post([FromBody] Sports user)
        {
            _sportService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Sports user)
        {
            _sportService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _sportService.Delete(id);
        }
    }
}
