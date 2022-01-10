using System;

namespace classes_constructor
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

            Employee e2 = new("murat", "karaca", 23436546, "backend");
            string e2Info = e2.EmployeeInfo();
            Console.WriteLine(e2Info);

            Employee e3 = new("MURAT", "KARACA");
            string e3Info = e3.EmployeeInfo();
            Console.WriteLine(e3Info);
        }
    }

    class Employee
    {
        public string Name;
        public string LastName;
        public int Num;
        public string Department;

        public Employee() { }

        public Employee(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }

        public Employee(string name, string lastName, int num, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Num = num;
            this.Department = department;
        }
        public string EmployeeInfo()
        {
            return $"Çalışanlarımızdan {this.Name} {this.LastName}'ın numarası {this.Num}'dır ve {this.Department} biriminde çalışmaktadır.";
        }

    }
}
