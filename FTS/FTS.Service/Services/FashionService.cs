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
        public Fashion GetById(long id)
        {
            return _fashionRepository.GetById(id);
        }
        public void Insert(Fashion fashion)
        {
            _fashionRepository.Insert(fashion);
        }
        public void Update(Fashion fashion)
        {
            _fashionRepository.Update(fashion);
        }

        public void Delete(long id)
        {
            _fashionRepository.Delete(id);
        }
    }
}
