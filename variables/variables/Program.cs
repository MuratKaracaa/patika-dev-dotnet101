using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 0;
            sbyte b = -127;
            short c = short.MinValue;
            ushort d = ushort.MaxValue;
            Console.WriteLine(c);
            Console.WriteLine(d);

            Int16 e = 5;
            int f = 6;
            Int32 g = 7;
            Int64 h = 8;

            uint i = 9;
            long j = 10;
            ulong k = 11;

            float l = 12;
            double m = 13;
            decimal n = 14;


            bool r = true;
            bool s = false;

            DateTime dt = DateTime.Now;

            object t = "16";
            object u = 123213;


            string abc = string.Empty;
            abc = "test";
            string name = "murat";
            string lastName = "karaca";

            bool bl = 100 > -100;

            string vb = "20";
            int ty = 20;
            string nr = vb + ty.ToString();
            int er = ty + Convert.ToInt32(vb);

            DateTime now = DateTime.UtcNow;

        }
    }
}
