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
    public class FashionService : IFashionService
    {
        IFashionRepository _fashionRepository ;
        public FashionService(IFashionRepository fashionRepository)
        {
            _fashionRepository = fashionRepository;
        }
        public IEnumerable<Fashion> GetAll()
        {
            return _fashionRepository.GetAll();
        }
        public Fashion GetById(long userId)
        {
            return _fashionRepository.GetById(userId);
        }
        public void Insert(Fashion user)
        {
            _fashionRepository.Insert(user);
        }
        public void Update(Fashion user)
        {
            _fashionRepository.Update(user);
        }

        public void Delete(long id)
        {
            _fashionRepository.Delete(id);
        }
    }
}
