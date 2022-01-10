using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir sayı girin:");
            int n = int.Parse(Console.ReadLine());

            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = char.ConvertFromUtf32(65 + i);
            }

            foreach (string c in arr)
            {
                Console.Write(c);
            }
        }
    }
}
