using Library_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<BookData>> GetBooks()
        {
            return Ok(BookData.books.book);
        }

        [HttpGet("{Id}")]
        public ActionResult GetBook(int id)
        {
            // Find City
            var BookToReturn = BookData.books.book.FirstOrDefault(c => c.Id == id);

            if (BookToReturn == null)
            {
                return NotFound();
            }
            return Ok(BookToReturn);
        }

        [HttpPost("savebook")]
        public ActionResult SaveBook(string name, string author)
        {
            BookModel book = new BookModel()
            {
                Name = name,
                Author = author
            };

            BookData.books.book.Add(book);

            return Ok(book);
        }

        [HttpPost("saveuserbook")]
        public ActionResult SaveUserBook(int userId, int bookId)
        {
            UserBookModel userbook = new UserBookModel()
            {
                BookId = bookId,
                UserId = userId
            };

            BookData.books.userbook.Add(userbook);

            return Ok(true);
        }
    }
}
