using System;
using System.Collections.Generic;

namespace classes_statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new("murat", "karaca", "backend");
            Employee.PrintCount();
            Employee e2 = new("Murat", "Karaca", "Sunucu Geliştirme");
            Employee.PrintCount();
            List<double> sumList = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(math.Sum(sumList));
        }
    }

    class Employee
    {
        private static int employeeCount;

        private string name;

        private string lastName;

        private string department;

        public static int EmployeeCount { get => employeeCount; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Department { get => department; set => department = value; }

        static Employee()
        {
            employeeCount = 0;
        }

        public Employee(string name, string lastName, string department)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Department = department;
            employeeCount++;
        }

        public static void PrintCount()
        {
            Console.WriteLine(employeeCount);
        }
    }

    static class math
    {
        public static double Sum(List<double> list)
        {
            double sum = 0;
            foreach (double i in list) sum += i;
            return sum;
        }

        public static double Substract(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
