using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (string first in firstArray)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    string second = secondArray[i];

                    if (first == second)
                    {
                        Console.Write(second + " ");
                        break;
                    }
                }
            }



        }
    }
}
