using Library_Management_System.Models;

namespace Library_Management_System
{
    public class UserData
    {
        public List<UserModel> user { get; set; }
        public static UserData users { get; set; } = new UserData();
        public UserData()
        {
            user = new List<UserModel>()
            {
                new UserModel()
                {
                    Id = 1,
                    Name = "User_1"
                },
                new UserModel()
                {
                    Id = 2,
                    Name = "User_2"
                },
                new UserModel()
                {
                    Id = 3,
                    Name = "User_3"
                },
                new UserModel()
                {
                    Id = 4,
                    Name = "User_4"
                },
                new UserModel()
                {
                    Id = 5,
                    Name = "User_5"
                }
            };
        }

    }
}
