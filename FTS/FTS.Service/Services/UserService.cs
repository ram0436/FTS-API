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
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IEnumerable<Users> GetAll()
        {
            return _userRepository.GetAll();
        }
        public Users GetById(long id)
        {
            return _userRepository.GetById(id);
        }
        public void Insert(Users user)
        {
            _userRepository.Insert(user);
        }
        public void Update(Users user)
        {
            _userRepository.Update(user);
        }

        public void Delete(long id)
        {
            _userRepository.Delete(id);
        }
    }
}
