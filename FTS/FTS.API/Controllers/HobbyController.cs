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
        public void Post([FromBody] Hobbies user)
        {
            _hobbyService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Hobbies user)
        {
            _hobbyService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _hobbyService.Delete(id);
        }
    }
}
