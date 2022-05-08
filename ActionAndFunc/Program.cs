using System;
using System.Text.RegularExpressions;

namespace ActionAndFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Del = (a, b) => a - b;
            Func<double, double, double> Multi = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) => b == 0 ? 0 : (a / b); 

            double value = Add(3, 5);
            Console.WriteLine(value);
            
            value = Calculator(Add, 10, 20);
            Console.WriteLine(value);

            value = Calculator(Multi, 7, 9);
            Console.WriteLine(value);

            Console.WriteLine("Please enter your operation, and numbers, separated by comma");
            var text = Console.ReadLine();
            string[] inputs = text.Split(',');
            foreach (var input in inputs)
            {
                Console.WriteLine(input);
            }

            var op = inputs[0];
            double a = Convert.ToDouble(inputs[1]);
            double b = Convert.ToDouble(inputs[2]);

            var result = op switch
            {
                "add" => Calculator(Add, a, b),
                "del" => Calculator(Del, a, b),
                "multi" => Calculator(Multi, a, b),
                "div" => Calculator(Div, a, b)
            };
            Console.WriteLine($"resule value = {result}");
        }

        public static double Calculator(Func<double, double, double> op, double a, double b)
        {
            return op(a, b); 
        }
    }
}