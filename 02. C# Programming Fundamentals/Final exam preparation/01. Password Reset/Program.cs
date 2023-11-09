using System;
using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            
            while (commands != "Done")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
                string action = tokens[0];

                if (action == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(input[i]);
                        }
                    }
                    input = sb.ToString();
                    Console.WriteLine(input);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int lenghtToRomove = int.Parse(tokens[2]);
                    input = input.Remove(startIndex, lenghtToRomove);

                    Console.WriteLine(input);
                }
                else if (action == "Substitute")
                {
                    string sub = tokens[1];
                    string substitude = tokens[2];


                    if (input.Contains(sub))
                    {
                        input = input.Replace(sub, substitude);

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }                    
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
