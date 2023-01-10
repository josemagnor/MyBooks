

namespace MyBooks.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Book>> GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Book> GetOneBook(int id)
        {
            return Ok(_bookService.GetBookByID(id));
        }

        [HttpPost]
        public ActionResult<List<Book>> AddOneBook(Book newBook)
        {   
            return Ok(_bookService.AddBook(newBook));
        }
        
        [HttpPut]
        [Route("{id}")]
        public ActionResult<List<Book>> UpdateOneBook(int id, Book newBook)
        {
            return Ok(_bookService.UpdateBook(id,newBook));
        }
        
        [HttpDelete]
        [Route("{id}")]
        public ActionResult<List<Book>> DeleteOneBook(int id)
        {   
            return Ok(_bookService.DeleteBookByID(id));
        }
        
        [HttpPut]
        public ActionResult DeleteAllBooks()
        {
            _bookService.DeleteAllBooks();
            return Ok("books deleted");
        }

    }
}