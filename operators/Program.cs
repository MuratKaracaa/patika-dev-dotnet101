using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Op

            int i = 1;
            i += 1;
            i *= 10;
            i /= 5;
            i %= 3;
            i -= 1;

            // Mantıksal Op

            bool b1 = true;
            bool b2 = false;

            if (b1 && b2)
                Console.WriteLine("her iki durum");

            if (b1 || b2)
                Console.WriteLine("bir durum");

            if (!b1)
                Console.WriteLine("zıttı");

            // İlişkisel

            // Aritmetik
        }
    }
}
