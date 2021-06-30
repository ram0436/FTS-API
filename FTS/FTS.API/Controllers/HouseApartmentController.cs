using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseApartmentController : ControllerBase
    {

        private IHouseApartmentService _houseApartmentService ;
        public HouseApartmentController(IHouseApartmentService houseApartmentService)
        {
            _houseApartmentService = houseApartmentService;
        }

        [HttpGet]
        public IEnumerable<HouseApartments> GetAll()
        {
            return _houseApartmentService.GetAll();
        }

        [HttpGet("{id}")]
        public HouseApartments GetById(long id)
        {
            return _houseApartmentService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] HouseApartments houseApartment)
        {
            _houseApartmentService.Insert(houseApartment);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] HouseApartments houseApartment)
        {
            _houseApartmentService.Update(houseApartment);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _houseApartmentService.Delete(id);
        }
    }
}
