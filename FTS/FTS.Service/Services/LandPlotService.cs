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
        public LandPlots GetById(long userId)
        {
            return _landPlotRepository.GetById(userId);
        }
        public void Insert(LandPlots user)
        {
            _landPlotRepository.Insert(user);
        }
        public void Update(LandPlots user)
        {
            _landPlotRepository.Update(user);
        }

        public void Delete(long id)
        {
            _landPlotRepository.Delete(id);
        }
    }
}
