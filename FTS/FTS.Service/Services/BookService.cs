﻿using FTS.Model.Entities;
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
        public Books GetById(long userId)
        {
            return _bookRepository.GetById(userId);
        }
        public void Insert(Books user)
        {
            _bookRepository.Insert(user);
        }
        public void Update(Books user)
        {
            _bookRepository.Update(user);
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }
    }
}
