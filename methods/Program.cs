using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            math math = new math();
            long fact = math.Factorial(6);
            long comg = math.Combination(10, 3);
            Print(fact);
            Print(comg);
        }

        static void Print(object data)
        {
            Console.WriteLine(data);
        }


    }

    class math
    {
        public static long Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        public static long Combination(int n, int g)
        {
            return Factorial(n) / (Factorial(g) * Factorial(n - g));
        }
    }
}


