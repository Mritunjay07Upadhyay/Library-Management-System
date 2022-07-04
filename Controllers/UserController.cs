﻿using Library_Management_System.Models;
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
                new User() { Id = 1, Name = "Sandeep"},
                new User() { Id = 2, Name = "Mritunjay"},
                new User() { Id = 3, Name = "Rahul"}
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

        [HttpGet("ID")]
        public IActionResult GetUser(int Id)
        {
            var user = Users.FirstOrDefault(x => x.Id == Id);
            if (user == null)
            {
                return NotFound("No Record Found");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult PostUser(User user)
        {
            Users.Add(user);
            if (Users.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(Users);
        }

        [HttpDelete]
        public IActionResult DeleteUser(int Id)
        {
            var user = Users.FirstOrDefault(x => x.Id == Id);
            if (user == null)
            {
                return NotFound("No User Found");
            }
            Users.Remove(user);

            if (Users.Count == 0)
            {
                return NotFound("No Record Found");
            }
            return Ok(Users);
        }

    }
} 
