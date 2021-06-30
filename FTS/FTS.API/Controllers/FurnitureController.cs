using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureController : ControllerBase
    {

        private IFurnitureService _furnitureService ;
        public FurnitureController(IFurnitureService furnitureService)
        {
            _furnitureService = furnitureService;
        }

        [HttpGet]
        public IEnumerable<Furnitures> GetAll()
        {
            return _furnitureService.GetAll();
        }

        [HttpGet("{id}")]
        public Furnitures GetById(long id)
        {
            return _furnitureService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Furnitures furniture)
        {
            _furnitureService.Insert(furniture);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Furnitures furniture)
        {
            _furnitureService.Update(furniture);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _furnitureService.Delete(id);
        }
    }
}
