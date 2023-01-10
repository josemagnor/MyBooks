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

        public async Task<ServiceResponse<List<Book>>> AddBook(Book newBook)
        {   
            var serviceResponse = new ServiceResponse<List<Book>>(); 
            books.Add(newBook);
            serviceResponse.Data = books;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Book>>> DeleteBookByID(int id)
        {   
            var request = books.FirstOrDefault(b => b.BookID == id);
            var serviceResponse = new ServiceResponse<List<Book>>(); 
            if( request is not null)
                books.Remove(request);
            serviceResponse.Data = books;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Book>>> GetAllBooks()
        {
           var serviceResponse = new ServiceResponse<List<Book>>();
           serviceResponse.Data = books; 
           return serviceResponse;
        }

        public async Task<ServiceResponse<Book>> GetBookByID(int id)
        {   
            var serviceResponse = new ServiceResponse<Book>();
            var request = books.FirstOrDefault(b => b.BookID == id);
            if(request is null)
                throw new Exception("Book not found"); // possivel retorno nulo
            else       
                serviceResponse.Data = request;
                return serviceResponse;
            
        }

        public async Task<ServiceResponse<List<Book>>> UpdateBook(int id, Book newBook)
        {
            var request = books.FirstOrDefault(b=>b.BookID == id);
            var serviceResponse = new ServiceResponse<List<Book>>();
            if(request is null)
                throw new Exception("book not found to update");

            books.Remove(request);
            books.Add(newBook);
            serviceResponse.Data = books;
            return serviceResponse;
        }


    }
}