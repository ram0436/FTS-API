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
    public class ElectricApplianceService : IElectricApplianceService

    {
        IElectricApplianceRepository _electricApplianceRepository;
        public ElectricApplianceService(IElectricApplianceRepository electricApplianceRepository)
        {
            _electricApplianceRepository = electricApplianceRepository;
        }
        public IEnumerable<ElectricAppliances> GetAll()
        {
            return _electricApplianceRepository.GetAll();
        }
        public ElectricAppliances GetById(long id)
        {
            return _electricApplianceRepository.GetById(id);
        }
        public void Insert(ElectricAppliances electricAppliance)
        {
            _electricApplianceRepository.Insert(electricAppliance);
        }
        public void Update(ElectricAppliances electricAppliance)
        {
            _electricApplianceRepository.Update(electricAppliance);
        }

        public void Delete(long id)
        {
            _electricApplianceRepository.Delete(id);
        }
    }
}
