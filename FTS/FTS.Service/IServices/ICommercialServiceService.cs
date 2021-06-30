using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface ICommercialServiceService
    {
        IEnumerable<CommercialServices> GetAll();
        CommercialServices GetById(long id);
        void Insert(CommercialServices obj);
        void Update(CommercialServices obj);
        void Delete(long id);

    }
}
