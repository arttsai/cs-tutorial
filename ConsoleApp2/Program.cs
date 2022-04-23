using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            foo f = null;
            int? i = f?.run() ?? 0 ;

            if (i.HasValue)
                Console.WriteLine(i);
            else
                Console.WriteLine("null");

            int? b = 5;
            b ??= 12;
            Console.WriteLine("b = {0}", b);
        }
    }
    
    class foo {
        public int run() { return 42; }
    }
    
}