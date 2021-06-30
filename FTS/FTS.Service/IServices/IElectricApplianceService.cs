using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IElectricApplianceService

    {
        IEnumerable<ElectricAppliances> GetAll();
        ElectricAppliances GetById(long id);
        void Insert(ElectricAppliances obj);
        void Update(ElectricAppliances obj);
        void Delete(long id);

    }
}
