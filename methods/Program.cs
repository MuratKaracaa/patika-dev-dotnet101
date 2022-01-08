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

            int sum = math.add(3, 5);
            math.add(6, 8, out int sum2);

            string merged = math.add("günaydınlar", "efendim");
            math.add("good", "morning", out string merged2);

            Print(sum);
            Print(sum2);
            Print(merged);
            Print(merged2);

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

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static void add(int a, int b, out int c)
        {
            c = a + b;
        }

        public static string add(string a, string b)
        {
            return a + " " + b;
        }

        public static void add(string a, string b, out string c)
        {
            c = a + " " + b;
        }
    }
}


