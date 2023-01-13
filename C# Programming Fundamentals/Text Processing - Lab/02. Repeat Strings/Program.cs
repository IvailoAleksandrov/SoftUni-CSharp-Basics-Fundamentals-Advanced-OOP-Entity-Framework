using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string repeated = string.Empty;

            //foreach (var word in words)
            //{
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        repeated += word;
            //    }
            //}

            //Console.WriteLine(repeated);

            StringBuilder sb = new StringBuilder();

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb);


        }
    }
}
