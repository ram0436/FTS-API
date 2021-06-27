using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FashionController : ControllerBase
    {

        private IFashionService _fashionService ;
        public FashionController(IFashionService fashionService)
        {
            _fashionService = fashionService;
        }

        [HttpGet]
        public IEnumerable<Fashion> GetAll()
        {
            return _fashionService.GetAll();
        }

        [HttpGet("{id}")]
        public Fashion GetById(long id)
        {
            return _fashionService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Fashion user)
        {
            _fashionService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Fashion user)
        {
            _fashionService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _fashionService.Delete(id);
        }
    }
}
