using System;
using System.Collections.Generic;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new();

            User user1 = new User()
            {
                Email = "testuser1@hotmail.com",
                Hash = "dfsdfdsfdsf",
                Salt = "dsşfksfşlsdfsdfsdf",
                Number = 58961651
            };

            User user2 = new User()
            {
                Email = "testuser2@hotmail.com",
                Hash = "dsfe34thtr",
                Salt = "fgbfghtk5tr",
                Number = 684123165
            };

            userList.Add(user1);
            userList.Add(user2);

            foreach (User u in userList)
            {
                Console.WriteLine($"Kullanıcı emaili: {u.Email}");
                Console.WriteLine($"Kullanıcı numarası: {u.Number}");
            }
        }
    }

    class User
    {
        private string email;
        private string hash;
        private string salt;
        private int number;

        public string Email { get => email; set => email = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Salt { get => salt; set => salt = value; }
        public int Number { get => number; set => number = value; }
    }
}
