using FTS.Model.Entities;
using FTS.Repository.IRepositories;
using FTS.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.Services
{
    public class LandPlotService : ILandPlotService
    {
        ILandPlotRepository _landPlotRepository;
        public LandPlotService(ILandPlotRepository landPlotRepository)
        {
            _landPlotRepository = landPlotRepository;
        }
        public IEnumerable<LandPlots> GetAll()
        {
            return _landPlotRepository.GetAll();
        }
        public LandPlots GetById(long id)
        {
            return _landPlotRepository.GetById(id);
        }
        public void Insert(LandPlots landPlot)
        {
            _landPlotRepository.Insert(landPlot);
        }
        public void Update(LandPlots landPlot)
        {
            _landPlotRepository.Update(landPlot);
        }

        public void Delete(long id)
        {
            _landPlotRepository.Delete(id);
        }
    }
}
