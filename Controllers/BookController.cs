using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public ActionResult<IEnumerable<BookData>> GetBooks()
        {
            return Ok(BookData.books.book);
        }
    }
}
