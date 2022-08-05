using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int time = projects * 3;
            Console.WriteLine($"The architect {name} will need {time} hours to complete {projects} project/s.");
        }
    }
}
