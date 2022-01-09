using System;

namespace oop_inheritance
{
    class Admin : User
    {
        private string title;

        public string Title { get => title; set => title = value; }

        public Admin(string userName, string email, string hash, string salt, string title) : base(userName, email, hash, salt)
        {
            this.Title = title;
        }
    }
}