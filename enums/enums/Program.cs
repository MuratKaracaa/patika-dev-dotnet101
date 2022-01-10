using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bulunduğunuz ayın sayısını giriniz: ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case (int)Months.January:
                case (int)Months.February:
                case (int)Months.December:
                    Console.WriteLine(Seasons.Winter);
                    break;
                case (int)Months.March:
                case (int)Months.April:
                case (int)Months.May:
                    Console.WriteLine(Seasons.Spring);
                    break;
                case (int)Months.June:
                case (int)Months.July:
                case (int)Months.August:
                    Console.WriteLine(Seasons.Summer);
                    break;
                case (int)Months.September:
                case (int)Months.October:
                case (int)Months.November:
                    Console.WriteLine(Seasons.Fall);
                    break;
                default:
                    Console.WriteLine("Hatalı input!");
                    break;
            }
        }
    }

    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    enum Seasons
    {
        Winter,
        Spring,
        Summer,
        Fall
    }
}
