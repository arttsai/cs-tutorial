using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> GetNumbers()
            {
                // for (int i = 1; i <= 100; ++i)
                // {
                //     Thread.Sleep(1000);
                //     Console.WriteLine($"Produced: {i}");
                //     yield return i;
                // } 
                
                var list = new List<int>();
                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Produced: {i}");
                    list.Add(i);
                }

                return list; 
            }
            
            foreach(var i in GetNumbers().Take(5))
            {
                Console.WriteLine($"Consumed: {i}");
            }

            // Console.WriteLine("Second Call:");
            // Console.WriteLine();
            // foreach(var i in GetNumbers().Take(5))
            // {
            //     Console.WriteLine($"Consumed: {i}");
            // }
        }
    }
}