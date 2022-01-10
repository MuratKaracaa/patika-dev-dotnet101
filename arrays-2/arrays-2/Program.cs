using System;

namespace arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random r = new Random();

            Console.WriteLine("********New Arr*********");
            // Create a list with Random Nums
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 100);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            // Sort the generated arr
            Console.WriteLine("********Sorted Arr*********");
            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            // Reverse the generated arr
            Console.WriteLine("********Reversed Sorted Arr*********");
            Array.Reverse<int>(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
