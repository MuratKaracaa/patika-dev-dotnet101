using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new()
            {
                Name = "Murat",
                LastName = "Karaca",
                Num = 23423423,
                Department = "Sunucu Geliştirme"
            };

            string e1Info = e1.EmployeeInfo();
            Console.WriteLine(e1Info);
        }
    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int Num;
        public string Department;

        public string EmployeeInfo()
        {
            return $"Çalışanlarımızdan {this.Name} {this.LastName}'ın numarası {this.Num}'dır ve {this.Department} biriminde çalışmaktadır.";
        }

    }
}
