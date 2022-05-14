using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqGroup
{
    // 今天的練習題:
    // https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.groupby?view=net-6.0#system-linq-enumerable-groupby-4(system-collections-generic-ienumerable((-0))-system-func((-0-1))-system-func((-0-2))-system-func((-1-system-collections-generic-ienumerable((-2))-3))-system-collections-generic-iequalitycomparer((-1)))
    //
    // 將一群寵物的年紀做分組, 以整數年紀為 key 做分組, 並印每組的寵物的名字，以及計算每組的成員數量，以及每組總共有幾隻腳 。
    //
    // 寵物有dog, duck, snake。

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // GroupByEx1();   // reference from MS 官網  

            GroupByUsingKeyAndElement(); 
        }

        private static void GroupByUsingKeyAndElement()
        {
            var text = @"Lorem ipsum dolor sit amet, consectetur adipiscing
            elit, sed do eiusmod tempor incididunt ut labore et dolore
                magna aliqua.";
                
            var groups = text.Split(new char[] { ' ', ',', '.', '\n' })
                .GroupBy(w => w.Length, w => w.ToLower())
                .Where(g => g.Key > 0)
                .OrderBy(g => g.Key);
            
            foreach (var group in groups)
            {
                Console.WriteLine($"Length={group.Key}");
                foreach (var word in group)
                {
                    Console.WriteLine($"\t {word}");
                }
            }
        }

        public static void GroupByEx1()
        {
            // Create a list of pets.
            List<Pet> pets =
                new List<Pet>{ new Pet { Name="Barley", Age=8 },
                    new Pet { Name="Boots", Age=4 },
                    new Pet { Name="Whiskers", Age=1 },
                    new Pet { Name="Daisy", Age=4 } };

            // Group the pets using Age as the key value
            // and selecting only the pet's Name for each value.
            IEnumerable<IGrouping<int, string>> query =
                pets.GroupBy(pet => pet.Age, pet => pet.Name);

            // Iterate over each IGrouping in the collection.
            foreach (IGrouping<int, string> petGroup in query)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(petGroup.Key);
                // Iterate over each value in the
                // IGrouping and print the value.
                foreach (string name in petGroup)
                    Console.WriteLine("  {0}", name);
            }
        }
    }
    
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Animal
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public int Legs { get; protected set; }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Legs = 4; 
        }
    }

    public class Duck : Animal
    {
        public Duck()
        {
            Legs = 2;
        }
    }

    public class Snake : Animal
    {
        public Snake()
        {
            Legs = 0; 
        }
    }
}