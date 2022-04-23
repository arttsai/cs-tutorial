using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 10;
            int b = a / 0;

            Console.WriteLine("Hi again hello world!");

            // try
            // {
            //     int a = 10;
            //     int b = a / 0;
            // }
            // catch (DivideByZeroException ex)
            // {
            //     Console.WriteLine("This is a DivideByZeroException object");
            // }
            // catch (System.Exception ex)
            // {
            //     Console.WriteLine(ex);
            // }
        }
    }
}