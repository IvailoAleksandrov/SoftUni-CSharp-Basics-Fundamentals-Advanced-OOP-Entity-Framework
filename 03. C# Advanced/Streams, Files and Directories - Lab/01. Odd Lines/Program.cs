using System;
using System.IO;

namespace _01._Odd_Lines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../NewFileFolder/Input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../NewFileFolder/Output.txt"))
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
