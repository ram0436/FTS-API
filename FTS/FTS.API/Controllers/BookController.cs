using FTS.Model.Entities;
using FTS.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FTS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Books> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpGet("{id}")]
        public Books GetById(long id)
        {
            return _bookService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Books book)
        {
            _bookService.Insert(book);
        }

        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Books book)
        {
            _bookService.Update(book);
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _bookService.Delete(id);
        }
    }
}
