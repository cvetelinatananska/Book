using Book2023.DL.Memori.DL;
using Book2023.Models.models;
using BookStore.DL.interfaces;

namespace BookStore.DL.Repository
{
    public class BookRepository : IBookRepository
    {
        public void AddBook(Book book)
        {
            StaticData.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var book =
                StaticData.Books
                .FirstOrDefault(b => b.id == id);
            if (book == null) return;
            StaticData.Books.Remove(book.id);
        }

        public void UpdateBook(Book book)
        {

            var existingBook =
               StaticData.Books
               .FirstOrDefault(b => b.id == book.id);

            if (existingBook == null) return;


            existingBook.Title = book.Title;

        }
    

    public void GetBook(int id)
    {
        return
               StaticData.Books
               .FirstOrDefault(b => b.id == id);

    }

    public List<Book> GetAllBook()
    {
        return StaticData.Books;
    }
}
}
