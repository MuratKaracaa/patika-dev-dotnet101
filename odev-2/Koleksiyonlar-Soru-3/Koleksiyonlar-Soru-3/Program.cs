using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string input = Console.ReadLine();
            List<char> vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<char> filtered = new();
            foreach (char v in input) if (vowels.Contains(v)) filtered.Add(v);
            foreach (char v in filtered) Console.Write(v + " ");
        }
    }
}
