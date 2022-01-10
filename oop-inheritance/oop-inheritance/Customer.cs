using System;

namespace oop_inheritance
{
    class Customer : User
    {
        private string billingAddress;
        private string deliveryAddrress;

        public string BillingAddress { get => billingAddress; set => billingAddress = value; }
        public string DeliveryAddrress { get => deliveryAddrress; set => deliveryAddrress = value; }

        public Customer(string userName, string email, string hash, string salt, string billingAddress, string deliveryAddrress) : base(userName, email, hash, salt)
        {
            this.BillingAddress = billingAddress;
            this.DeliveryAddrress = deliveryAddrress;
        }
    }
}