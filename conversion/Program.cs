using System;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i = 5;
            int j = i;

            string a = "1";
            byte b = Byte.Parse(a);

            decimal d = 10;
            float f = (float)d;

            long l = 1000;
            int x = (int)l;


        }
    }
}
