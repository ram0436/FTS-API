using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IJobService

    {
        IEnumerable<Jobs> GetAll();
        Jobs GetById(long userId);
        void Insert(Jobs obj);
        void Update(Jobs obj);
        void Delete(long userId);

    }
}
