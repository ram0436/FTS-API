using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IPetService

    {
        IEnumerable<Pets> GetAll();
        Pets GetById(long userId);
        void Insert(Pets obj);
        void Update(Pets obj);
        void Delete(long userId);

    }
}
