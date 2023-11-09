using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (dictionary.ContainsKey(wordInLowerCase))
                {
                    dictionary[wordInLowerCase] += 1;
                }
                else
                {
                    dictionary.Add(wordInLowerCase, 1);
                }
            }
            

            foreach (var word in dictionary)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");            
                }
            }
            
        }
        
    }
}
