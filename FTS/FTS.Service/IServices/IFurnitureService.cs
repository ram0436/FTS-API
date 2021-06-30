using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IFurnitureService

    {
        IEnumerable<Furnitures> GetAll();
        Furnitures GetById(long id);
        void Insert(Furnitures obj);
        void Update(Furnitures obj);
        void Delete(long id);

    }
}
