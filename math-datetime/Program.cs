using System;

namespace math_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            // şu anın ayrı ayrı propları
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.Year);
            // şu andan itibaren belirtilen miktarda ekleme çıkarma
            Console.WriteLine(DateTime.Now.AddDays(10));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(-1));
            // şu anın ve ekleme yapılmış zamanın formatlanması
            Console.WriteLine(DateTime.Now.ToString("ddd-MMM-yyyy"));
            Console.WriteLine(DateTime.Now.AddYears(-3).ToString("yyyy-MM-dd"));
            //math kütüphanesi temel işlemler
            Console.WriteLine(Math.Abs(-1000));
            Console.WriteLine(Math.Pow(5, 123));
            Console.WriteLine(Math.Cos(90));
            Console.WriteLine(Math.Tan(90));
            Console.WriteLine(Math.Sin(90));

            //math ile sayı yuvarlama
            Console.WriteLine(Math.Ceiling(3.6));
            Console.WriteLine(Math.Round(37.3));
            Console.WriteLine(Math.Round(37.9));
            Console.WriteLine(Math.Floor(65.3));
        }
    }
}
