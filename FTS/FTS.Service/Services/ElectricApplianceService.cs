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
        public ElectricAppliances GetById(long userId)
        {
            return _electricApplianceRepository.GetById(userId);
        }
        public void Insert(ElectricAppliances user)
        {
            _electricApplianceRepository.Insert(user);
        }
        public void Update(ElectricAppliances user)
        {
            _electricApplianceRepository.Update(user);
        }

        public void Delete(long id)
        {
            _electricApplianceRepository.Delete(id);
        }
    }
}
