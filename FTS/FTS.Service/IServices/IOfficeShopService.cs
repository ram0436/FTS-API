using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IOfficeShopService

    {
        IEnumerable<OfficeShops> GetAll();
        OfficeShops GetById(long id);
        void Insert(OfficeShops obj);
        void Update(OfficeShops obj);
        void Delete(long id);

    }
}
