using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static FTS.Configuration.Enum.EnumList;

namespace FTS.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

       // [Authorize(Roles = "Admin")]
        [HttpGet]
        public IEnumerable<Users> GetAll()
        {
            return _userService.GetAll();
        }
      //  [Authorize(Roles = "SuperAdmin")]
        [HttpGet("{id}")]
        public Users GetByUserId(long id)
        {
            return _userService.GetById(id);
        }
       // [Authorize(Roles = "User")]
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
