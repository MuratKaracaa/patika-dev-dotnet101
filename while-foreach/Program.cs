using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int sum = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine(sum);

            char c = 'a';
            while (c <= 'z')
            {
                Console.Write(c);
                c++;
            }

            string[] lessons = { "math", "chem", "psy", "phys", "econ" };

            foreach (string el in lessons)
            {
                Console.WriteLine(el);
            }

        }
    }
}
