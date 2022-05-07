using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var student = new Student();
            var str = student.Show();

            var teacher = new Teacher();
            var str2 = teacher.Show();
        }
    }

    class Student
    {
        public string No { get; set; }
        public string Name { get; set; }
        
        public Student(string name, string no)
        {
            Name = name;
            No = no;
        }
    }

    class Teacher
    {
        public string Name { get; set; }
    }

    class Extension
    {
        public static string Show(this Student student)
        {
            Console.WriteLine($"student's name is {student.Name}");
            return student.Name; 
        }

        public static string Show(this Teacher teacher) => teacher.Name; 
    }
}