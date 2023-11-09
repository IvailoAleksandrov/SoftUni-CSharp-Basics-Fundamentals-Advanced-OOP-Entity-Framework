using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            //Stack<char> stack = new Stack<char>();

            //foreach (char symbol in message)
            //{
            //    stack.Push(symbol);
            //}
            //foreach (char symbol in stack)
            //{
            //    Console.Write(symbol);
            //}message
            // Second Try
            Stack<char> stack = new Stack<char>(message.ToCharArray());

            Console.WriteLine(string.Join("",stack));

            foreach (var symbol in message)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
