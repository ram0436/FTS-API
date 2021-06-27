using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IPGService

    {
        IEnumerable<PG> GetAll();
        PG GetById(long userId);
        void Insert(PG obj);
        void Update(PG obj);
        void Delete(long userId);

    }
}
