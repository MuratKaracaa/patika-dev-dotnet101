using System;

namespace oop_inheritance
{
    class User
    {
        private string userName;
        private string email;
        private string hash;
        private string salt;

        public User(string userName, string email, string hash, string salt)
        {
            UserName = userName;
            Email = email;
            Hash = hash;
            Salt = salt;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Salt { get => salt; set => salt = value; }
    }
}