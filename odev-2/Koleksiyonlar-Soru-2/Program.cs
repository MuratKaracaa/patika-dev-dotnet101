using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("20 adet sayı girin:");
            int i = 0;
            int[] inputArray = new int[20];
            int[] min3 = new int[3];
            int[] max3 = new int[3];
            while (i < 20)
            {
                try
                {
                    Console.Write($"{i + 1}. sayıyı girin: ");
                    int input = int.Parse(Console.ReadLine());
                    if (input < 0) throw new Exception("Lütfen pozitif bir sayı girin");
                    else
                    {
                        inputArray[i] = input;
                        i++;
                    }
                }
                catch (System.Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Array.Sort(inputArray);
            foreach (int el in inputArray) Console.WriteLine("input: " + el);
            for (int a = 0, b = inputArray.Length - 1; a < 3 && b > inputArray.Length - 4; a++, b--)
            {
                min3[a] = inputArray[a];
                max3[a] = inputArray[b];
            }

            double min3Avg = Average(min3);
            double max3Avg = Average(max3);
            Console.WriteLine($"Girilen sayılardan en küçük 3 sayının ortalaması {min3Avg}, en büyük 3 sayının ortalaması {max3Avg} ve ortalamalar toplamı {min3Avg + max3Avg}'dir.");
        }

        static double Average(int[] arr)
        {
            double result = 0;
            foreach (int i in arr) result += i;
            return result / arr.Length;
        }
    }
}
