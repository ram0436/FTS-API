using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PGController : ControllerBase
    {

        private IPGService _pGService ;
        public PGController(IPGService pGService)
        {
            _pGService = pGService;
        }

        [HttpGet]
        public IEnumerable<PG> GetAll()
        {
            return _pGService.GetAll();
        }

        [HttpGet("{id}")]
        public PG GetById(long id)
        {
            return _pGService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] PG pg)
        {
            _pGService.Insert(pg);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] PG pg)
        {
            _pGService.Update(pg);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _pGService.Delete(id);
        }
    }
}
