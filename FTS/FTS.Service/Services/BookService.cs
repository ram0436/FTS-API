using FTS.Model.Entities;
using FTS.Repository.IRepositories;
using FTS.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Service.Services
{
    public class BookService : IBookService

    {
        IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IEnumerable<Books> GetAll()
        {
            return _bookRepository.GetAll();
        }
        public Books GetById(long id)
        {
            return _bookRepository.GetById(id);
        }
        public void Insert(Books book)
        {
            _bookRepository.Insert(book);
        }
        public void Update(Books book)
        {
            _bookRepository.Update(book);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }
    }
}
