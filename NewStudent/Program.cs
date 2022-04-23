using System;
using System.Dynamic;

namespace NewStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var student = new Student("12", "John");

            
            // this won't work 
            // var obj = new CountedClass();
            
            var obj1 = CountedClass.Create(); 
            var obj2 = CountedClass.Create();

            Console.WriteLine($"CountedClass has {CountedClass.Count} objects");
            
            // singleton pattern : using private constructor 
            ExampleSingleton(); 

        }

        private static void ExampleSingleton()
        {
            var count = Singleton.Instance.Count;
            Console.WriteLine($"singleton count = {count}");

        }
    }

    internal class Singleton
    {
        private static Singleton _singletonObj;
        public int Count { get; set; }

        public static Singleton Instance 
        {
            get 
            {
                if (_singletonObj == null)
                    _singletonObj = new Singleton();
                return _singletonObj;
            } 
        }
        
        private Singleton() 
        {
        }
        
    }

    internal class CountedClass
    {
        public static int Count { get; set; }

        public static CountedClass Create()
        {
            Count++;
            if (Count > 100)
                throw new Exception("超過 100個了");

            return new CountedClass();
        }
        
        private CountedClass()   // 這種 private 的建構子, 外面是叫不到的, 因此無法建立物件 
        {
        }
    }

    internal class Student : Person
    {
        public string No { get; set; }  // property 
        public ClassRoom ClassRoom;             // field 

        public Student(string no, string name)
        {
            No = no;
            Name = name; 
        }
    }

    internal class ClassRoom
    {
        public string ClassName { get; set; }
    }

    internal class Person
    {
        public string Name { get; set; }
        public string socialId; 
    }
    
    
}