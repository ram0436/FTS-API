using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IGadgetService

    {
        IEnumerable<Gadgets> GetAll();
        Gadgets GetById(long id);
        void Insert(Gadgets obj);
        void Update(Gadgets obj);
        void Delete(long id);

    }
}
