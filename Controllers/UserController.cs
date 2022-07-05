using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public ActionResult<IEnumerable<UserData>> GetUsers()
        {
            return Ok(UserData.users.user);
        }

        [HttpGet("{ID}")]
        public ActionResult GetUser(int id)
        {
            // Find City
            var UserToReturn = UserData.users.user.FirstOrDefault(c => c.Id == id);

            if (UserToReturn == null)
            {
                return NotFound();
            }
            return Ok(UserToReturn);
        }
    }
}
