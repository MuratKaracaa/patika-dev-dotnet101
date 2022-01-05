// See https://aka.ms/new-console-template for more information
using System;

namespace console 
{
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("İsminizi girin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyisminizi girin: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hoşgeldin" + " " + name + " " + lastName);

        }
    }
}