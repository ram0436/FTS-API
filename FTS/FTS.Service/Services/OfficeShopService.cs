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
    public class OfficeShopService : IOfficeShopService
    {
        IOfficeShopRepository _officeShopRepository ;
        public OfficeShopService(IOfficeShopRepository officeShopRepository)
        {
            _officeShopRepository = officeShopRepository;
        }
        public IEnumerable<OfficeShops> GetAll()
        {
            return _officeShopRepository.GetAll();
        }
        public OfficeShops GetById(long id)
        {
            return _officeShopRepository.GetById(id);
        }
        public void Insert(OfficeShops officeShops)
        {
            _officeShopRepository.Insert(officeShops);
        }
        public void Update(OfficeShops officeShops)
        {
            _officeShopRepository.Update(officeShops);
        }

        public void Delete(long id)
        {
            _officeShopRepository.Delete(id);
        }
    }
}
