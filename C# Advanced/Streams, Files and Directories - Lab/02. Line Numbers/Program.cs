using System;
using System.IO;
using System.Xml;

namespace _02._Line_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    int lineNumber = 1;
                    while (line!= null)
                    {
                        writer.WriteLine($"Line {lineNumber}: {line}");
                        lineNumber++;
                        line = reader.ReadLine();

                    }
                }
            }
        }
    }
}
