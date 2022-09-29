using System;
using System.Linq;

namespace _14._Using_LINQ_descedenting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring and initializing the
            // array with 6 positive number
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort the arr in decreasing order
            // and return a array
            arr = arr.OrderByDescending(c => c).ToArray();

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
