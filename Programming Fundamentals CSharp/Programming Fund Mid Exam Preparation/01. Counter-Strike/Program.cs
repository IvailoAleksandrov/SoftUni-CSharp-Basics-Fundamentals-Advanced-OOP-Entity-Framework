using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int counter = 0;


            while (command!= "End of battle")
            {
                int distance = int.Parse(command);


                if (energy >= distance)
                {
                    energy -= distance;
                    counter++;
                }
                else if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
                }
                
                if (counter % 3 == 0)
                {
                    energy += counter;
                }
                command = Console.ReadLine();
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
            }
            
        }
    }
}
