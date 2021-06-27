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
        public CommercialServices GetById(long userId)
        {
            return _commercialServiceRepository.GetById(userId);
        }
        public void Insert(CommercialServices user)
        {
            _commercialServiceRepository.Insert(user);
        }
        public void Update(CommercialServices user)
        {
            _commercialServiceRepository.Update(user);
        }

        public void Delete(long id)
        {
            _commercialServiceRepository.Delete(id);
        }
    }
}
