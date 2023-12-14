using Book2023.Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfacces
{
    public interface IBookServicces
    {
        public void AddBook(Book book);


        public void DeleteBook(int id);


        public void UpdateBook(Book book);


        public void GetBook(int id);

        public List<Book> GetAllBook();
    }
}
