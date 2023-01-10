using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooks.Services.BookService
{
    public class BookService : IBookService
    {
        private static List<Book> books = new List<Book>
        {
            new Book(),
            new Book{BookID = 2, BookName = "Queen Mary"},
            new Book{BookID = 3, BookName = "Titanic"},
            new Book{BookID = 4, BookName = "Leonard"}
        };

        public List<Book> AddBook(Book newBook)
        {
            books.Add(newBook);
            return books;
        }

        public List<Book> DeleteBookByID(int id)
        {   
            var request = books.FirstOrDefault(b => b.BookID == id);
            if( request is not null)
                books.Remove(request);
            return books;
        }

        public List<Book> GetAllBooks()
        {
           return books;
        }

        public Book GetBookByID(int id)
        {   
            var request = books.FirstOrDefault(b => b.BookID == id);
            if(request is not null)
                return request;
            throw new Exception("Book not found"); // possivel retorno nulo
        }

        public List<Book> UpdateBook(int id, Book newBook)
        {
            var request = books.FirstOrDefault(b=>b.BookID == id);
            if(request is null)
                throw new Exception("book not found to update");

            books.Remove(request);
            books.Add(newBook);
            return books;
        }

        public void DeleteAllBooks()
        {
            books.Clear();
        }
    }
}