using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Library_Management_System.Models;


namespace Library_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GETController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public GETController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GET()
        {
            string query = @"SELECT * FROM BOOKDETAIL";
            DataTable dt = new DataTable();
            string SqlDataSource = _configuration.GetConnectionString("DBConn");
            SqlDataReader myReader;
            List<Book> books = new List<Book>();

            using (SqlConnection myConn = new SqlConnection(SqlDataSource))
            {
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myConn.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(myCommand);
                    sqlDataAdapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Book book = new Book()
                        {
                            Title = row["Title"].ToString(),
                            Author = row["Author"].ToString(),
                            ID = row["ID"].ToString(),
                            Copyrights = row["Copyrights"].ToString()
                        };
                        books.Add(book);
                    }

                    myConn.Close();
                    sqlDataAdapter.Dispose();
                }
            }
            return Ok(books);
        }

    }
}
