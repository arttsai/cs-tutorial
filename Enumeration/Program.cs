using System;
using System.Diagnostics;
using System.Security.Principal;

namespace Enumeration
{
    public enum Priority
    {
        Low=0,
        Normal=1,
        Important=2,
        Urgent=3
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int priority = 2;
            switch (priority)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                default:
                    break;
            }

            Priority p1 = Priority.Normal;
            switch(p1)
            {
                case Priority.Low:
                    // skip 
                    break;
                case Priority.Normal:
                    // do something 
                    break;
                case Priority.Important:
                    // do something
                    // escalate 
                    // acknowledge 
                    break; 
                case Priority.Urgent:
                    
                default:
                    throw new Exception("weird priority!!");
                    break;
            }


        }
    }
}