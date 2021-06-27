using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface ILandPlotService

    {
        IEnumerable<LandPlots> GetAll();
        LandPlots GetById(long userId);
        void Insert(LandPlots obj);
        void Update(LandPlots obj);
        void Delete(long userId);

    }
}
