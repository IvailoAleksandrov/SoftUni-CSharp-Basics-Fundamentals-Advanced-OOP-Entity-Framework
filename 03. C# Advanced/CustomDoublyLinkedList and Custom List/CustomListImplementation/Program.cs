using System;

namespace CustomListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.RemoveAt(0));
            Console.WriteLine(list.Count);

            bool isContains = list.Contains(2);
            Console.WriteLine(isContains);

            list.Swap(1,2);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[3]);

            




        }
    }
}
