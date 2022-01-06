using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi girin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyisminizi girin: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hoşgeldin" + " " + name + " " + lastName);
        }
    }
}
