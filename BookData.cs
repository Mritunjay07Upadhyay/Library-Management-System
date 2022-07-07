using Library_Management_System.Models;

namespace Library_Management_System
{
    public class BookData
    {
        public List<BookModel> book { get; set; }
        public List<UserBookModel> userbook { get; set; }
        public static BookData books { get; set; } = new BookData();
       

        public BookData()
        {
            userbook = new List<UserBookModel>();
          
            book = new List<BookModel>()
            {
                new BookModel()
                {
                    Id = 1,
                    Name = "Book1",
                    Author = "Author1"
                },
                new BookModel()
                {
                    Id = 2,
                    Name = "Book2",
                    Author = "Author2"
                },
                new BookModel()
                {
                    Id = 3,
                    Name = "Book3",
                    Author = "Author3"
                },
                new BookModel()
                {
                    Id = 4,
                    Name = "Book4",
                    Author = "Author4"
                },
                new BookModel()
                {
                    Id = 5,
                    Name = "Book5",
                    Author = "Author5"
                }
            };
        }

    }
}
