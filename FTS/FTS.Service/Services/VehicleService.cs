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
    public class VehicleService : IVehicleService
    {
        IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public IEnumerable<Vehicles> GetAll()
        {
            return _vehicleRepository.GetAll();
        }
        public Vehicles GetById(long id)
        {
            return _vehicleRepository.GetById(id);
        }
        public void Insert(Vehicles vehicle)
        {
            _vehicleRepository.Insert(vehicle);
        }
        public void Update(Vehicles vehicle)
        {
            _vehicleRepository.Update(vehicle);
        }

        public void Delete(long id)
        {
            _vehicleRepository.Delete(id);
        }
    }
}
