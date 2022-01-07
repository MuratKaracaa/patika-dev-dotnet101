using System;

namespace ternaryOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            string message = hour >= 6 && hour <= 10 ? "Good morning" : hour > 10 && hour <= 14 ? "Good day" : hour <= 18 ? "Good afternoon" : "Good evening";
            Console.WriteLine(message);
        }
    }
}
