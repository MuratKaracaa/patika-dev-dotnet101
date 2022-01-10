using System;

namespace oop_inheritance
{
    class Seller : User
    {
        private string shopId;
        private string shopLocation;

        public string ShopId { get => shopId; set => shopId = value; }
        public string ShopLocation { get => shopLocation; set => shopLocation = value; }

        public Seller(string userName, string email, string hash, string salt, string shopId, string shopLocation) : base(userName, email, hash, salt)
        {
            this.ShopId = shopId;
            this.ShopLocation = shopLocation;
        }
    }
}