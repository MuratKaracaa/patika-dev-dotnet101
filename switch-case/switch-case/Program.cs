using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   // 0 100 arası tek sayılar için atlamasız for loop - continue
               for (int i = 0; i <= 100; i++)
               {
                   if (i % 2 == 0) continue;
                   Console.WriteLine(i);
               }*/

            // 1 100 arası sayılarda rakamları toplamı 15 olan bir sayıya geldiğinde looptan çıkma - break

            for (int i = 1; i <= 100; i++)
            {
                int n = i;
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                if (sum == 15)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
