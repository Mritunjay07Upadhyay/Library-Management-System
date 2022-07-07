using Library_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookUserController : ControllerBase
    {
        [HttpPost]
        public ActionResult SaveUserBook([FromBody]UserBookModel book)
        {

            //UserBookModel userbook = new UserBookModel()
            //{
            //    BookId = bookId,
            //    UserId = userId
            //};

            // BookData.books.userbook.Add(userbook);

            BookData.books.userbook.Add(book);

            return Ok(book);
        }

        [HttpGet]
        public ActionResult GetUserBook(int userId)
        {
            var userbooks = BookData.books.userbook.Where(x => x.UserId == userId).ToList();

            return Ok(userbooks);
        }
    }
}
