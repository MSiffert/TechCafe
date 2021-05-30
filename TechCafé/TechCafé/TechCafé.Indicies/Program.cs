using System;
using System.Collections.Generic;

namespace TechCafé.Indicies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
            
            Console.WriteLine(numbers[^0]);
            Console.WriteLine(numbers[^1]);

            Console.WriteLine("-----------------------");
            
            foreach (var number in numbers[..])
            {
                Console.WriteLine(number);
            }
            
            Console.WriteLine("-----------------------");

            foreach (var number in numbers[2..6])
            {
                Console.WriteLine(number);
            }
            
            Console.WriteLine("-----------------------");

            Range range = 1..4;
            foreach (var number in numbers[range])
            {
                Console.WriteLine(number);
            }
            
            Console.ReadKey();
        }
    }
}