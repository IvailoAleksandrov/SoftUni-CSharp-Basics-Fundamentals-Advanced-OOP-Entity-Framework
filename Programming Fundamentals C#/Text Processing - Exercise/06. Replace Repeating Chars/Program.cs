using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  

            StringBuilder stringBuilder= new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[i+1])
                {
                    stringBuilder.Append(input[i]);
                }
            }
            stringBuilder.Append(input[input.Length - 1]);
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
