using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>() {synonym});

                }
                else
                {
                    words[word].Add(synonym);
                    
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
                
            }

        }
    }
}
