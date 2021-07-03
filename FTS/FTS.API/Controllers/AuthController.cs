using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost]
        public IActionResult Login(Users userLogin)
        {

            IActionResult response = Unauthorized();
            string res = _authService.Authenticate(userLogin);
            if (res != string.Empty)
            {
                response = Ok(new { token = res });
            }
            return response;

        }
    }
}
