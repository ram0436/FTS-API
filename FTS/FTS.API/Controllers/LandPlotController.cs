using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandPlotController : ControllerBase
    {

        private ILandPlotService _landPlotService ;
        public LandPlotController(ILandPlotService landPlotService)
        {
            _landPlotService = landPlotService;
        }

        [HttpGet]
        public IEnumerable<LandPlots> GetAll()
        {
            return _landPlotService.GetAll();
        }

        [HttpGet("{id}")]
        public LandPlots GetById(long id)
        {
            return _landPlotService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] LandPlots landPlot)
        {
            _landPlotService.Insert(landPlot);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] LandPlots landPlot)
        {
            _landPlotService.Update(landPlot);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _landPlotService.Delete(id);
        }
    }
}
