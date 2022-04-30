using System;

namespace SampleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IEngine
    {
        int Power { get; }
        void Start();
    }

    public class DieselEngine : IEngine
    {
        public int Power { get; }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}