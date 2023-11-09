using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            List<string> strings = new List<string>();

            strings.Add("abc");
            strings.Add("xyz");
            strings.Add("qwerty");

            Stack<string> result = stackOfStrings.AddRange(strings);
            Console.WriteLine(string.Join(Environment.NewLine,result));
            Console.WriteLine(result.Pop());
            Console.WriteLine(result.Peek());
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
