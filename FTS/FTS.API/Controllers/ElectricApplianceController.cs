using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricApplianceController : ControllerBase
    {

        private IElectricApplianceService _electricApplianceService ;
        public ElectricApplianceController(IElectricApplianceService electricApplianceService)
        {
            _electricApplianceService = electricApplianceService;
        }

        [HttpGet]
        public IEnumerable<ElectricAppliances> GetAll()
        {
            return _electricApplianceService.GetAll();
        }

        [HttpGet("{id}")]
        public ElectricAppliances GetById(long id)
        {
            return _electricApplianceService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] ElectricAppliances user)
        {
            _electricApplianceService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] ElectricAppliances user)
        {
            _electricApplianceService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _electricApplianceService.Delete(id);
        }
    }
}
