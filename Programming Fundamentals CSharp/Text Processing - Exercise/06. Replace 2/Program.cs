using System;

namespace _06._Replace_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char previosChar = text[0];
            Console.Write(previosChar);

            for (int i = 1; i < text.Length; i++)
            {
                char currChar = text[i];
                if (previosChar != currChar)
                {
                    previosChar = currChar;
                    Console.Write(previosChar);
                }
            }
        }
    }
}
