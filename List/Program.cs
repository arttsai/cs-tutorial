using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var intList = new List<int>() { 1, 2, 3, 4 };
            var strList = new List<string> { "a", "b", "c" };
            var gameUnits = new List<GameUnit>()   // Listkov Principle 
            {
                new GameUnit(new Position(5, 5)), 
                new GameUnit(),
                new Terrain(),
                new Water(),
                new Hill()
            };

            foreach (var gameUnit in gameUnits)
            {
                Console.WriteLine(gameUnit.ToString());
            }

            var index3 = intList[3];  // List class has setup indexer function 

            var a = new List<List<string>>();
            a.Append(new List<string> { "a", "b", "c" });
            a.Append(new List<string>() { "x", "y", "z" });

            foreach (var el in a)
            {
                foreach (var e in el)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();
                Console.WriteLine();
            }


        }
    }

    internal class GameUnit
    {
        public Position position { get; set; }
        
        public GameUnit()
        {
        }

        public GameUnit(Position p)
        {
            position = p; 
        }
    }

    internal class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Position(int x = 0, int y = 0)
        {
            X = x;
            Y = y; 
        }
    }

    internal class Terrain : GameUnit
    {
        
    }

    internal class Water : Terrain
    {
        
    }

    internal class Hill : Terrain
    {
        
    }
    
    
}