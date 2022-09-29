using System;

namespace _01._Reversed_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            // get array size
            int lenght = array.Length;
            // declare and create the reversed array
            int[] reversed = new int[lenght];
            // initialize the reversed array
            for (int i = 0; i < lenght; i++)
            {
                reversed[lenght-i-1] = array[i];

            }
            // print the reversed array
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(reversed[i] + " ");
            }
        }
    }
}
