using Library_Management_System.Models;

namespace Library_Management_System
{
    public class BookData
    {
        public List<BookModel> book { get; set; }
        public static BookData books { get; set; } = new BookData();
        public BookData()
        {
            book = new List<BookModel>()
            {
                new BookModel()
                {
                    Id = 1,
                    Name = "Book1"
                },
                new BookModel()
                {
                    Id = 2,
                    Name = "Book2"
                },
                new BookModel()
                {
                    Id = 3,
                    Name = "Book3"
                },
                new BookModel()
                {
                    Id = 4,
                    Name = "Book4"
                },
                new BookModel()
                {
                    Id = 5,
                    Name = "Book5"
                }
            };
        }

    }
}
