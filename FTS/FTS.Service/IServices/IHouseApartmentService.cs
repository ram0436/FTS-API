using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IHouseApartmentService

    {
        IEnumerable<HouseApartments> GetAll();
        HouseApartments GetById(long userId);
        void Insert(HouseApartments obj);
        void Update(HouseApartments obj);
        void Delete(long userId);

    }
}
