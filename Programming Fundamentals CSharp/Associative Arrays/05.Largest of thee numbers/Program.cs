using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Largest_of_thee_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            List<double> result = numbers.OrderByDescending(x => x).Take(3).ToList(); 
            
            List<double> result1 = numbers.Select(x => x*2 + 100).Take(3).ToList();
            List<double> result2 = numbers.Where(x => x % 2 == 0).Take(3).ToList();
            


            Console.WriteLine(string.Join(" ", result));
            Console.WriteLine(string.Join(" ", result1));  // try diferent LINQ func.
            Console.WriteLine(string.Join(" ", result2));
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.FirstOrDefault(x => x== 2));
        }
    }
}
