using System;

namespace recursives_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursive recursive = new Recursive();
            Console.WriteLine(recursive.Add(5));

            string test = "selamlar türkiye";

            Console.WriteLine(test.FirstCharsUpperCase());
            int[] arr = { 1, -10, 100, 5000, 150, -1500 };
            Console.WriteLine(arr.FindMax());
            Console.WriteLine(arr.FindMin());
            Console.WriteLine(arr.GetSum());

        }
    }

    public class Recursive
    {
        public int Add(int n)
        {
            if (n == 1) return 1;
            return n + Add(n - 1);
        }
    }

    public static class Extension
    {
        public static string FirstCharsUpperCase(this string param)
        {
            string[] split = param.Split(" ");
            for (int i = 0; i < split.Length; i++)
            {
                split[i] = split[i].Substring(0, 1).ToUpper() + split[i].Substring(1, split[i].Length - 1);
            }
            return String.Join(" ", split);
        }

        public static int FindMax(this int[] param)
        {
            int max = int.MinValue;
            foreach (int i in param)
            {
                max = i > max ? i : max;
            }
            return max;
        }

        public static int FindMin(this int[] param)
        {
            int min = int.MaxValue;
            foreach (int i in param)
            {
                min = i < min ? i : min;
            }
            return min;
        }

        public static long GetSum(this int[] param)
        {
            long sum = 0;
            foreach (int i in param)
            {
                sum += i;
            }
            return sum;
        }
    }


}
