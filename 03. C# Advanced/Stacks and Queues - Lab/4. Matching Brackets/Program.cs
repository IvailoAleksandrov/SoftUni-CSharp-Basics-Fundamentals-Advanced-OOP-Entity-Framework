using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> expression = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    expression.Push(i);
                }
                else if (input[i] == ')')
                {
                    int indexOpening = expression.Pop();
                    Console.WriteLine(input.Substring(indexOpening, i - indexOpening + 1));
                }
            }
        }
    }
}
