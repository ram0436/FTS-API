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
    public class FurnitureService : IFurnitureService
    {
        IFurnitureRepository _furnitureRepository;
        public FurnitureService(IFurnitureRepository furnitureRepository)
        {
            _furnitureRepository = furnitureRepository;
        }
        public IEnumerable<Furnitures> GetAll()
        {
            return _furnitureRepository.GetAll();
        }
        public Furnitures GetById(long id)
        {
            return _furnitureRepository.GetById(id);
        }
        public void Insert(Furnitures furniture)
        {
            _furnitureRepository.Insert(furniture);
        }
        public void Update(Furnitures furniture)
        {
            _furnitureRepository.Update(furniture);
        }

        public void Delete(long id)
        {
            _furnitureRepository.Delete(id);
        }
    }
}
