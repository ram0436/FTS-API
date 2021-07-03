using FTS.Model.DbContexts;
using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static FTS.Configuration.Enum.EnumList;

namespace FTS.Service.Services
{
    public class AuthService : IAuthService
    {
        private FTSDbContext _dbContext;
        private IConfiguration _config;
        public AuthService(FTSDbContext dbContext, IConfiguration config)
        {
            _dbContext = dbContext;
            _config = config;
        }
        public string Authenticate(Users user)
        {
            var _user = AuthenticateUser(user);

            if (_user != null)
            {
                var tokenString = GenerateJSONWebToken(_user);
                return tokenString;
            }
            return "Invalid User";
        }

        private string GenerateJSONWebToken(Users userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private Users AuthenticateUser(Users user)
        {
            Users user1 = _dbContext.Users.Where(x => x.UserId == user.UserId && x.Password == user.Password).ToList().FirstOrDefault();
            return user1;
        }

       // This methode I was checking with role, but its not working, will see later
        //private string GenerateJSONWebToken(Users user)
        //{
        //    string role = GetRole(user);
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //        {
        //            new Claim(ClaimTypes.Name, user.Id.ToString()),
        //            new Claim(ClaimTypes.Role, role)
        //        }),
        //        Expires = DateTime.UtcNow.AddDays(7),
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha384Signature)
        //    };
        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    string Token1 = tokenHandler.WriteToken(token);
        //    return Token1;
        //}

        //private string GetRole(Users user)
        //{
        //    string role = string.Empty;
        //    switch (user.Role)
        //    {
        //        case (Role)1:
        //            role = "SuperAdmin";
        //            break;
        //        case (Role)2:
        //            role = "Admin";
        //            break;
        //        case (Role)3:
        //            role = "User";
        //            break;
        //    }
        //    return role;
        //}
    }
}
