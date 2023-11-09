using System;
using System.IO;

namespace _01._Odd_lines_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);

        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int counter = 0;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (counter++ % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
