

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
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            return Ok(await _bookService.GetAllBooks());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Book>> GetOneBook(int id)
        {
            return Ok(await _bookService.GetBookByID(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddOneBook(Book newBook)
        {   
            return Ok(await _bookService.AddBook(newBook));
        }
        
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Book>>> UpdateOneBook(int id, Book newBook)
        {
            return Ok(await _bookService.UpdateBook(id,newBook));
        }
        
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Book>>> DeleteOneBook(int id)
        {   
            return Ok(await _bookService.DeleteBookByID(id));
        }
        
    }
}