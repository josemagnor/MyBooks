using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooks.Services.BookService
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookByID(int id);
        List<Book> AddBook(Book newBook);
        List<Book> UpdateBook(int id, Book newBook);
        List<Book> DeleteBookByID(int id);
        void DeleteAllBooks();

    }
}