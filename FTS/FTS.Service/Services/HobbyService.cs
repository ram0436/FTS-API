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
        public Hobbies GetById(long userId)
        {
            return _hobbyRepository.GetById(userId);
        }
        public void Insert(Hobbies user)
        {
            _hobbyRepository.Insert(user);
        }
        public void Update(Hobbies user)
        {
            _hobbyRepository.Update(user);
        }

        public void Delete(long id)
        {
            _hobbyRepository.Delete(id);
        }
    }
}
