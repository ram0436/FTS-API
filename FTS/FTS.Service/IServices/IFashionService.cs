using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IFashionService

    {
        IEnumerable<Fashion> GetAll();
        Fashion GetById(long userId);
        void Insert(Fashion obj);
        void Update(Fashion obj);
        void Delete(long userId);

    }
}
