using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IHobbyService

    {
        IEnumerable<Hobbies> GetAll();
        Hobbies GetById(long userId);
        void Insert(Hobbies obj);
        void Update(Hobbies obj);
        void Delete(long userId);

    }
}
