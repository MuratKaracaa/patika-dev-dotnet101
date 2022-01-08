using System;
using System.Collections.Generic;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif bir sayı girin: ");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new();
            for (int i = 0; i < input; i++)
            {
                Console.Write($"{i + 1}. pozitif sayıyı girin: ");
                int num = Convert.ToInt32(Console.ReadLine());
                arr.Add(num);
            }

            foreach (int i in arr)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
        }
    }
}
