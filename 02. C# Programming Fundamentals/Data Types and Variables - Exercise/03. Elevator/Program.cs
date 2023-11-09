using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(people / capacity);
            Console.WriteLine(courses);
        }
    }
}
