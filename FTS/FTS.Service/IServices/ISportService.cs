using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface ISportService

    {
        IEnumerable<Sports> GetAll();
        Sports GetById(long userId);
        void Insert(Sports obj);
        void Update(Sports obj);
        void Delete(long userId);

    }
}
