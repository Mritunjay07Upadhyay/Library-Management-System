using Library_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public BookController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        List<Book> Books = new List<Book>() {
                new Book() { BookID = 1, BookTitle = "Book1"},
                new Book() { BookID = 2, BookTitle = "Book2"},
                new Book() { BookID = 3, BookTitle = "Book3"},
        };

        [HttpGet]
        public IActionResult GetBooks()
        {
            if (Books.Count == 0)
            {
                return NotFound("Try Again");
            }

            return Ok(Books);
        }

        [HttpGet("GetBook")]
        public IActionResult GetUser(int BookID)
        {
            var book = Books.FirstOrDefault(x => x.BookID == BookID);
            if (book == null)
            {
                return NotFound("No Record Found");
            }
            return Ok(book);
        }

    }
}
