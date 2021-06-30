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
    public class CommercialServiceService : ICommercialServiceService
    {
        ICommercialServiceRepository _commercialServiceRepository;
        public CommercialServiceService(ICommercialServiceRepository commercialServiceRepository)
        {
            _commercialServiceRepository = commercialServiceRepository;
        }
        public IEnumerable<CommercialServices> GetAll()
        {
            return _commercialServiceRepository.GetAll();
        }
        public CommercialServices GetById(long id)
        {
            return _commercialServiceRepository.GetById(id);
        }
        public void Insert(CommercialServices commercialService)
        {
            _commercialServiceRepository.Insert(commercialService);
        }
        public void Update(CommercialServices commercialService)
        {
            _commercialServiceRepository.Update(commercialService);
        }

        public void Delete(long id)
        {
            _commercialServiceRepository.Delete(id);
        }
    }
}
