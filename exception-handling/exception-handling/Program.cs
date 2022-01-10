using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.Parse("sdasds");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Bye..");
            }
        }
    }
}
