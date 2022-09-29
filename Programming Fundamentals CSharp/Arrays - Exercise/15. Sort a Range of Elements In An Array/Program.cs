using System;

namespace _15._Sort_a_Range_of_Elements_In_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of integers
            int[] intArray = new int[] { 9, 2, 4, 3, 1, 5, 6, 9, 5, 7, 1, 0 };
            // Sort array from 1st element to 6th element. Skip 0 element.
            Array.Sort(intArray, 1, 6);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(' ',intArray));
        }
    }
}
