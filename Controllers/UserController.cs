using Library_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
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

        [HttpPost]
        public ActionResult saveuser(int id, String name)
        {
            UserModel user = new UserModel()
            {
                Id = id,
                Name = name
            };
            UserData.users.user.Add(user);

            return Ok();
        }

        [HttpDelete]
        public ActionResult removeuser(int id)
        {
            //UserModel user = new UserModel()
            //{
            //    Id = id
            //};

            var itemToRemove = UserData.users.user.Single(r => r.Id == id);
            UserData.users.user.Remove(itemToRemove);

            // UserData.users.user.Remove(user);

            return Ok(true);
        }

    }
}
