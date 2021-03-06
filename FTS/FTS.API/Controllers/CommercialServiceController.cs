using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommercialServiceController : ControllerBase
    {

        private ICommercialServiceService _commercialServiceService;
        public CommercialServiceController(ICommercialServiceService commercialServiceService)
        {
            _commercialServiceService = commercialServiceService;
        }

        [HttpGet]
        public IEnumerable<CommercialServices> GetAll()
        {
            return _commercialServiceService.GetAll();
        }

        [HttpGet("{id}")]
        public CommercialServices GetById(long id)
        {
            return _commercialServiceService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] CommercialServices commercialService)
        {
            _commercialServiceService.Insert(commercialService);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] CommercialServices commercialService)
        {
            _commercialServiceService.Update(commercialService);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _commercialServiceService.Delete(id);
        }
    }
}
