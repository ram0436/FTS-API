using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {

        private IPetService _petService ;
        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpGet]
        public IEnumerable<Pets> GetAll()
        {
            return _petService.GetAll();
        }

        [HttpGet("{id}")]
        public Pets GetById(long id)
        {
            return _petService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Pets user)
        {
            _petService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Pets user)
        {
            _petService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _petService.Delete(id);
        }
    }
}
