using System;
using System.Threading.Tasks.Dataflow;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Ivo");
            int[] integers = ArrayCreator.Create(333, 333);
            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
