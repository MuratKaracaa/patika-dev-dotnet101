using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle yazınız: ");
            string input = Console.ReadLine();
            string[] split = input.Split(" ");
            int wordCount = split.Length;
            int letterCount = 0;

            foreach (string i in split) letterCount += i.Length;

            Console.WriteLine("Kelime Sayısı: " + wordCount);
            Console.WriteLine("Harf Sayısı: " + letterCount);
        }
    }
}
