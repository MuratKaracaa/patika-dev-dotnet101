using System;
using System.Collections.Generic;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arada boşluk bırakarak iki tane pozitif sayı girin:");
            string input = Console.ReadLine();
            int i1 = Convert.ToInt32(input.Split(" ")[0]);
            int i2 = Convert.ToInt32(input.Split(" ")[1]);
            Console.WriteLine(i1 + " " + i2);
            List<int> list = new();
            for (int i = 0; i < i1; i++)
            {
                Console.Write($"{i + 1}. pozitif sayıyı girin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                list.Add(n);
            }

            foreach (int i in list)
            {
                if (i % i2 == 0 || i == i2) Console.Write(i + " ");
            }
        }
    }
}
