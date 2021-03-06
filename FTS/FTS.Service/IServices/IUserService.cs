using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IUserService
    {
        IEnumerable<Users> GetAll();
        Users GetById(long id);
        void Insert(Users obj);
        void Update(Users obj);
        void Delete(long id);

    }
}
