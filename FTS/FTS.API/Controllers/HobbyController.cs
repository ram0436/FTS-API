using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbyController : ControllerBase
    {

        private IHobbyService _hobbyService ;
        public HobbyController(IHobbyService hobbyService)
        {
            _hobbyService = hobbyService;
        }

        [HttpGet]
        public IEnumerable<Hobbies> GetAll()
        {
            return _hobbyService.GetAll();
        }

        [HttpGet("{id}")]
        public Hobbies GetById(long id)
        {
            return _hobbyService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Hobbies hobby)
        {
            _hobbyService.Insert(hobby);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Hobbies hobby)
        {
            _hobbyService.Update(hobby);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _hobbyService.Delete(id);
        }
    }
}
