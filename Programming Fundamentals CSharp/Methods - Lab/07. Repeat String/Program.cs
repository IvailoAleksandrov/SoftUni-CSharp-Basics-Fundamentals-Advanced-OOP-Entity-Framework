using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int numRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedString(str, numRepeat)); 

        }

        static string RepeatedString(string str, int numRepeat)
        {
            string newString = string.Empty;

            for (int i = 0; i < numRepeat; i++)
            {
                newString += str;
            }
            
            return newString;
        }
    }
}
