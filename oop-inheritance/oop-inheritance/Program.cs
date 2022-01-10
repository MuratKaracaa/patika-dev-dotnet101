using System;

namespace oop_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("m.karaca", "deneme@hotmail.com", "asşldkalşd", "şkfdfds", "ankara", "ankara");
            Admin a1 = new Admin("m.karaca", "deneme@hotmail.com", "asşldkalşd", "şkfdfds", "bestadmin");
            Seller s1 = new Seller("m.karaca", "deneme@hotmail.com", "asşldkalşd", "şkfdfds", "denemeshop", "çankaya");
        }
    }
}
