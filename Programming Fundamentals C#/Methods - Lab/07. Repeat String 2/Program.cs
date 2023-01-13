using System;
using System.Text;

namespace _07._Repeat_String_2
{
    internal class Program
    {
        private static bool str;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, count));
        }

        private static string RepeatString(string input, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
