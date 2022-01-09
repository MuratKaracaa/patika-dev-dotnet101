using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("20 adet sayı girin:");
            int i = 0;
            ArrayList primes = new();
            ArrayList nonPrimes = new();
            while (i < 20)
            {
                try
                {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    int input = int.Parse(Console.ReadLine());
                    if (input <= 0) throw new Exception("Lütfen pozitif bir sayı girin");
                    else
                    {
                        if (CheckPrime(input)) primes.Add(input);
                        else nonPrimes.Add(input);
                        i++;
                    }
                }
                catch (System.Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            primes.Sort();
            nonPrimes.Sort();

            for (int a = primes.Count - 1; a >= 0; a--) Console.WriteLine("prime" + primes[a]);
            for (int a = nonPrimes.Count - 1; a >= 0; a--) Console.WriteLine("nonPrime" + nonPrimes[a]);

            double primeAvg = Average(primes);
            double nonPrimeAvg = Average(nonPrimes);

            Console.WriteLine($"Asal eleman sayısı {primes.Count}'tir ve ortalaması {primeAvg}'tir");
            Console.WriteLine($"Asal olmayan eleman sayısı {nonPrimes.Count}'tir ve ortalaması {nonPrimeAvg}'tir");
        }

        static bool CheckPrime(int n)
        {
            bool isPrime = true;
            if (n == 0 || n == 1) isPrime = false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) isPrime = false;
            }
            return isPrime;
        }

        static double Average(ArrayList arr)
        {
            double result = 0;
            foreach (int i in arr) result += i;
            return result / arr.Count;
        }
    }
}
