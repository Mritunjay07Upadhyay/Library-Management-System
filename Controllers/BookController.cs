using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public ActionResult<IEnumerable<BookData>> GetBooks()
        {
            return Ok(BookData.books.book);
        }

        [HttpGet("{Id}")]
        public ActionResult GetUser(int id)
        {
            // Find City
            var BookToReturn = BookData.books.book.FirstOrDefault(c => c.Id == id);

            if (BookToReturn == null)
            {
                return NotFound();
            }
            return Ok(BookToReturn);
        }
    }
}
