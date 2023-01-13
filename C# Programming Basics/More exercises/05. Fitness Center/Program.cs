using System;

namespace _05._Fitness_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;

            for (int i = 1; i <= people; i++)
            {
                string input = Console.ReadLine();

                if (input == "Back")
                {
                    back++;
                }
                if (input == "Chest")
                {
                    chest++;
                }
                if (input == "Legs")
                {
                    legs++;
                }
                if (input == "Abs")
                {
                    abs++;
                }
                if (input == "Protein shake")
                {
                    proteinShake++;
                }
                if (input == "Protein bar")
                {
                    proteinBar++;
                }

            }
            double procentWorkout = (chest + back + legs + abs) * 100.0 / people;
            double procentProtein = (proteinBar + proteinShake) * 100.0 / people;

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{procentWorkout:f2}% - work out");
            Console.WriteLine($"{procentProtein:f2}% - protein");

        }
    }
}
