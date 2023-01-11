using System;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
           Stack<string> stack = new Stack<string>();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                switch (action)
                {
                    case "Push":
                        string[] itemsToPush = tokens.Skip(1).ToArray();
                        for (int i = 0; i < itemsToPush.Length; i++)
                        {
                            stack.Push(itemsToPush[i]);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
