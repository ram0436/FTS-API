using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public IEnumerable<Users> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        public Users GetByUserId(long id)
        {
            return _userService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Users user)
        {
            _userService.Insert(user);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Users user)
        {
            _userService.Update(user);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _userService.Delete(id);
        }
    }
}
