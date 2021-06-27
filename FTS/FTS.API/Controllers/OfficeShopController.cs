using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeShopController : ControllerBase
    {

        private IOfficeShopService _officeShopService ;
        public OfficeShopController(IOfficeShopService officeShopService)
        {
            _officeShopService = officeShopService;
        }

        [HttpGet]
        public IEnumerable<OfficeShops> GetAll()
        {
            return _officeShopService.GetAll();
        }

        [HttpGet("{id}")]
        public OfficeShops GetById(long id)
        {
            return _officeShopService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] OfficeShops user)
        {
            _officeShopService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] OfficeShops user)
        {
            _officeShopService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _officeShopService.Delete(id);
        }
    }
}
