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
        public Pets GetById(long userId)
        {
            return _petRepository.GetById(userId);
        }
        public void Insert(Pets user)
        {
            _petRepository.Insert(user);
        }
        public void Update(Pets user)
        {
            _petRepository.Update(user);
        }

        public void Delete(long id)
        {
            _petRepository.Delete(id);
        }
    }
}
