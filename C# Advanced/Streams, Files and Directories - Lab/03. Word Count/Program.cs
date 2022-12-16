using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader("../../../words.txt"))
            {
                using (StreamReader textReader = new StreamReader("../../../text.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("../../../result.txt"))
                    {
                        string word = wordsReader.ReadLine();
                        while (word != null)
                        {
                            result.Add(word, 0);
                            word = wordsReader.ReadLine();
                        }

                        string textLine = textReader.ReadLine();
                        while (textLine != null)
                        {
                            string[] wordsInTextLine = textLine.ToLower().Split(new char[] { ' ', ',', '?', '!', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var wordInTextLine in wordsInTextLine)
                            {
                                if (result.ContainsKey(wordInTextLine))
                                {
                                    result[wordInTextLine]++;
                                }
                            }
                            textLine = textReader.ReadLine();
                        }
                        foreach (var pair in result.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{pair.Key} - {pair.Value} ");
                        }
                    }
                    
                }
            }
        }
    }
}
