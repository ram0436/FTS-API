using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        private IVehicleService _vehicleService ;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public IEnumerable<Vehicles> GetAll()
        {
            return _vehicleService.GetAll();
        }

        [HttpGet("{id}")]
        public Vehicles GetById(long id)
        {
            return _vehicleService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Vehicles vehicle)
        {
            _vehicleService.Insert(vehicle);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Vehicles vehicle)
        {
            _vehicleService.Update(vehicle);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _vehicleService.Delete(id);
        }
    }
}
