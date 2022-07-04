﻿using Library_Management_System.Models;
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
                new Book() { Id = 1, Title = "Book1"},
                new Book() { Id = 2, Title = "Book2"},
                new Book() { Id = 3, Title = "Book3"},
                new Book() { Id = 4, Title = "Book4"},
                new Book() { Id = 5, Title = "Book5"}
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

        [HttpGet("ID")]
        public IActionResult GetBook(int Id)
        {
            var book = Books.FirstOrDefault(x => x.Id == Id);

            if (book == null)
            {
                return NotFound("No Record Found");
            }
            return Ok(book);
        }

        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            Books.Add(book);
            if (Books.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(Books);
        }

        [HttpDelete]
        public IActionResult DeleteBook(int Id)
        {
            var book = Books.FirstOrDefault(x => x.Id == Id);
            if (book == null)
            {
                return NotFound("No User Found");
            }
            Books.Remove(book);

            if (Books.Count == 0)
            {
                return NotFound("No Record Found");
            }
            return Ok(Books);
        }

    }
}
