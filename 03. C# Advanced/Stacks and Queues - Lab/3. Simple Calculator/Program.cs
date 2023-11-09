using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();

            Stack<string> expressions = new Stack<string>(input);
            // 2 - 2 + 5    5 -2 + 2
            while (expressions.Count > 1)
            {
                int leftOperand = int.Parse(expressions.Pop()); // 2
                string operation = expressions.Pop();
                int rightOperand = int.Parse(expressions.Pop());
                int result = 0;
                switch (operation)
                {
                    case "+":
                        result = leftOperand + rightOperand;
                        expressions.Push(result.ToString());
                        break;
                    case "-":
                        result = leftOperand - rightOperand;
                        expressions.Push(result.ToString());
                        break;
                }

            }
            Console.WriteLine(expressions.Pop());
        }
    }
}
