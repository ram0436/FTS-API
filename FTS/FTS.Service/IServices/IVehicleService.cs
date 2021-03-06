using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IVehicleService
    {
        IEnumerable<Vehicles> GetAll();
        Vehicles GetById(long id);
        void Insert(Vehicles obj);
        void Update(Vehicles obj);
        void Delete(long id);

    }
}
