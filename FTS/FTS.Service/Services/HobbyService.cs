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
    public class HobbyService : IHobbyService
    {
        IHobbyRepository _hobbyRepository;
        public HobbyService(IHobbyRepository hobbyRepository)
        {
            _hobbyRepository = hobbyRepository;
        }
        public IEnumerable<Hobbies> GetAll()
        {
            return _hobbyRepository.GetAll();
        }
        public Hobbies GetById(long id)
        {
            return _hobbyRepository.GetById(id);
        }
        public void Insert(Hobbies hobby)
        {
            _hobbyRepository.Insert(hobby);
        }
        public void Update(Hobbies hobby)
        {
            _hobbyRepository.Update(hobby);
        }

        public void Delete(long id)
        {
            _hobbyRepository.Delete(id);
        }
    }
}
