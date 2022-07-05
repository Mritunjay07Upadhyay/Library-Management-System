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

        [HttpGet]
        public ActionResult GetUserBook(int userId)
        {
            var userbooks = BookData.books.userbook.Where(x => x.UserId == userId).ToList();

            return Ok(userbooks);
        }
    }
}
