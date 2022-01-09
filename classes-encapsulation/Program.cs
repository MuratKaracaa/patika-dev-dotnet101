using System;

namespace classes_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new()
            {
                Name = "Murat",
                LastName = "Karaca",
                Grade = 1,
                Num = 555
            };
            string s1Info = s1.studentInfo();
            Console.WriteLine(s1Info);

            Student s2 = new("murat", "karaca", 478, 4);
            string s2Info = s2.studentInfo();
            Console.WriteLine(s2Info);

        }
    }

    class Student
    {
        private string name;
        private string lastName;
        private int num;
        private int grade;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Num
        {
            get => num;
            set
            {
                if (value >= 100 && value <= 999) num = value;
                else throw new Exception("Geçersiz öğrenci numarası");
            }
        }
        public int Grade
        {
            get => grade;
            set
            {
                if (value >= 1 && value <= 4) grade = value;
                else throw new Exception("Geçersiz sınıf");
            }
        }

        public Student() { }

        public Student(string name, string lastName, int num, int grade)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Num = num;
            this.Grade = grade;
        }

        public void passGrade()
        {
            this.grade++;
        }

        public void revertGrade()
        {
            this.grade--;
        }

        public void changeGrade(int grade)
        {
            this.grade = grade;
        }

        public string studentInfo()
        {
            return
            $@"
            ------ Student Information ------
            Öğrencinin Ad ve Soyadı    : {this.Name} {this.LastName}
            Öğrencinin Numarası        : {this.Num}
            Öğrencinin Sınıfı          : {this.Grade}
            ";
        }
    }
}
