using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var student = new Student();

            Console.WriteLine(student.ToString());
            Console.WriteLine(student.GetType());

            var s3 = @"This text
spawns multiple lines.";
            Console.WriteLine(s3);

            string s = null; 


        }
        
    }

    struct StructA
    {
        int a;
        double d;
        string str; 
    }

    internal class Student
    {
        public Student()
        {
        }
    }
}
