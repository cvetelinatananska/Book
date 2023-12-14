using Book2023.Models.models;
using BookStore.BL.Interfacces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServicces _bookServicces;

        public BookController(IBookServicces bookServicces)
        {
            _bookServicces = bookServicces;
        }

        [HttpPost("AddBook")]
        public void Add([FromBody] Book book)
        {
            _bookServicces.AddBook(book);
        }

        [HttpGet("GetAll")]
        public void GetAll(int id)
        {
            _bookServicces.GetAll(id);
        }

        [HttpGet("GetById")]
        public void Get(int id)
        {
            _bookServicces.GetBook(id);
        }

        [HttpGet("Delate")]
        public void Delate(int id)
        {
            _bookServicces.GetBook(id);
        }

        [HttpGet("Update")]
        public void Update(int id)
        {
            _bookServicces.Update(id);
        }
    }
}
