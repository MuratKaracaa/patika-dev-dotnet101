using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı girin: ");
            String name = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin");
            String lastName = Console.ReadLine();
            String res = $"Hoşgeldin {name} {lastName}";

            Console.WriteLine(res);
        }
    }
}
