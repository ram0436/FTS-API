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
    public class PetService : IPetService
    {
        IPetRepository _petRepository;
        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public IEnumerable<Pets> GetAll()
        {
            return _petRepository.GetAll();
        }
        public Pets GetById(long id)
        {
            return _petRepository.GetById(id);
        }
        public void Insert(Pets pet)
        {
            _petRepository.Insert(pet);
        }
        public void Update(Pets pet)
        {
            _petRepository.Update(pet);
        }

        public void Delete(long id)
        {
            _petRepository.Delete(id);
        }
    }
}
