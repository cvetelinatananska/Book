using Book2023.Models.models;
using BookStore.BL.Interfacces;
using BookStore.DL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class BookService : IBookServicces
    {

        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

          public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public List<Book> GetAllBook()
        {
            return _bookRepository.GetAllBook();
        }

        public void GetBook(int id)
        {
            _bookRepository.GetBook(id);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.AddBook(book);
        }
    }
}
