using System;
using System.Text;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sb = new StringBuilder();
            sb.AppendLine("this is the first line");
            
            for (int i = 0; i<10;  i++)
            {
                if (i % 2 == 0) sb.AppendLine($"{i} is an even number."); 
            }

            sb.AppendLine("this is the 2nd line.")
                .AppendLine("this is the 3rd line."); 
            var str = sb.ToString();

            Console.WriteLine(str);
        }
    }
}