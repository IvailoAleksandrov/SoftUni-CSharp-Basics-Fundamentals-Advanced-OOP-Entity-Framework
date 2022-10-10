using System;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Remove odd numbers.
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    // Remove the element by specifying
                    // the zero-based index in the list.
                    numbers.RemoveAt(index);
                }
            }

            // Iterate through the list.
            // A lambda expression is placed in the ForEach method
            // of the List(T) object.
            numbers.ForEach(
                number => Console.Write(number + " "));
            // Output: 0 2 4 6 8
        }
    }
}
