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
        public void Post([FromBody] Vehicles user)
        {
            _vehicleService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Vehicles user)
        {
            _vehicleService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _vehicleService.Delete(id);
        }
    }
}
