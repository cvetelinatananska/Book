using Book2023.DL.Memori.DL;
using Book2023.Models.models;
using BookStore.DL.Repository;

namespace BookStore.DL.interfaces
{
    public interface IBookRepository 
    {

        public void AddBook(Book book);
        

        public void DeleteBook(int id);
       

        public void UpdateBook(Book book);


        public void GetBook(int id);

        public List<Book> GetAllBook();
      


    }
}
