using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GadgetController : ControllerBase
    {

        private IGadgetService _gadgetService ;
        public GadgetController(IGadgetService gadgetService)
        {
            _gadgetService = gadgetService;
        }

        [HttpGet]
        public IEnumerable<Gadgets> GetAll()
        {
            return _gadgetService.GetAll();
        }

        [HttpGet("{id}")]
        public Gadgets GetById(long id)
        {
            return _gadgetService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Gadgets gadget)
        {
            _gadgetService.Insert(gadget);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Gadgets gadget)
        {
            _gadgetService.Update(gadget);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _gadgetService.Delete(id);
        }
    }
}
