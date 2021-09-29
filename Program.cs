using System;

namespace Repositorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you know how much water, food and waste you produce or consume? Let's find out!\nType how much WATER you use on a daily basis:");        
        
            double water = Double.Parse(Console.ReadLine());

            Console.WriteLine("Type how much food you consume:");

            double food = Double.Parse(Console.ReadLine());

            Console.WriteLine("Type how much waste you produce:");

            double waste = Double.Parse(Console.ReadLine());

            Console.WriteLine("Great! Now, for how many people you want to calculate for?");

            double people = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{people} people, use {people*water}L water, consume {people*food}Kg food and produce {people*waste}Kg waste.");


        }
    }
}
