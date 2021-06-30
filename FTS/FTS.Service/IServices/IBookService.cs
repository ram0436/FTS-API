using FTS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.IServices
{
    public interface IBookService
    {
        IEnumerable<Books> GetAll();
        Books GetById(long id);
        void Insert(Books obj);
        void Update(Books obj);
        void Delete(long id);

    }
}
