using System;
using System.Collections.Generic;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir sayı girin: ");
            int input = Int16.Parse(Console.ReadLine());
            List<string> list = new();
            for (int i = 0; i < input; i++)
            {
                Console.Write($"{i + 1}. kelimeyi girin: ");
                string word = Console.ReadLine();
                list.Add(word);
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
