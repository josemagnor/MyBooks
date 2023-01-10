using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooks.Services.BookService
{
    public interface IBookService
    {
        Task<ServiceResponse<List<Book>>> GetAllBooks();
        Task<ServiceResponse<Book>> GetBookByID(int id);
        Task<ServiceResponse<List<Book>>> AddBook(Book newBook);
        Task<ServiceResponse<List<Book>>> UpdateBook(int id, Book newBook);
        Task<ServiceResponse<List<Book>>> DeleteBookByID(int id);

    }
}