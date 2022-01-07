using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            string message = String.Empty;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    message = "Kış mevsimi";
                    break;
                case 3:
                case 4:
                case 5:
                    message = "İlkbahar mevsimi";
                    break;
                case 6:
                case 7:
                case 8:
                    message = "Yaz mevsimi";
                    break;
                case 9:
                case 10:
                case 11:
                    message = "Sonbahar mevsimi";
                    break;
                default:
                    message = null;
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
