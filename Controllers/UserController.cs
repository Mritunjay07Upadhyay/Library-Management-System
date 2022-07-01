using Library_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        List<User> Users = new List<User>() {
                new User() { UserID = 1, UserName = "Sandeep"},
                new User() { UserID = 2, UserName = "Mritunjay"},
                new User() { UserID = 3, UserName = "Rahul"},    
        };

        [HttpGet]
        public IActionResult GetUsers()
        {
            if(Users.Count == 0)
            {
                return NotFound("Try Again");
            }

            return Ok(Users);
        }

        [HttpGet("GetUser")]
        public IActionResult GetUser(int UserID)
        {
            var user = Users.FirstOrDefault(x => x.UserID == UserID);
            if(user == null)
            {
                return NotFound("No Record Found");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult PostUser(User user)
        {
            Users.Add(user);
            if(Users.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(Users);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int UserID)
        {
            var user = Users.FirstOrDefault(x => x.UserID == UserID);
            if(user == null)
            {
                return NotFound("No User Found");
            }
            Users.Remove(user);

            if(Users.Count == 0)
            {
                return NotFound("No Record Found");
            }
            return Ok(Users);
        }

    }
} 
