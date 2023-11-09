using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!dict.ContainsKey(letter))
                    {
                        dict.Add(letter, 0);
                    }
                    dict[letter]++;
                    //dict[letter] += 1;
                }
            }
            foreach (var letter in dict)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }

        }
    }
}
