using System;

namespace string_metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Günaydın Türkiye";
            string str2 = "Bunlar güzel günlerimiz, daha beter olcak her şey";

            //String uzunluğu
            Console.WriteLine(str.Length + " " + str2.Length);
            //Büyük, küçük
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            //Concat
            Console.WriteLine(String.Concat(str2, " yandık bittik"));
            //Compare
            Console.WriteLine(String.Compare(str, str2, true));
            Console.WriteLine(String.Compare(str, str2, false));
            Console.WriteLine(str.CompareTo(str));
            //Contains
            Console.WriteLine(str.Contains("daasdas"));
            //Inser
            Console.WriteLine(str.Insert(0, "!"));
            //Remove
            Console.WriteLine(str.Remove(0, 3));
            //Replace
            Console.WriteLine(str.Replace("Günaydın", "Gutentag"));
            //Split
            Console.WriteLine(str.Split(" ")[0]);
            //Substring
            Console.WriteLine(str.Substring(5, 10));


        }
    }
}
