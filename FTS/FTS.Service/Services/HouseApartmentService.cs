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
    public class HouseApartmentService : IHouseApartmentService
    {
        IHouseApartmentRepository _houseApartmentRepository;
        public HouseApartmentService(IHouseApartmentRepository houseApartmentRepository)
        {
            _houseApartmentRepository = houseApartmentRepository;
        }
        public IEnumerable<HouseApartments> GetAll()
        {
            return _houseApartmentRepository.GetAll();
        }
        public HouseApartments GetById(long userId)
        {
            return _houseApartmentRepository.GetById(userId);
        }
        public void Insert(HouseApartments user)
        {
            _houseApartmentRepository.Insert(user);
        }
        public void Update(HouseApartments user)
        {
            _houseApartmentRepository.Update(user);
        }

        public void Delete(long id)
        {
            _houseApartmentRepository.Delete(id);
        }
    }
}
