using P01_GenericBoxOfString;
using System;
using System.Linq;

namespace _04._Generic_Swap_Method_Integer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            Box<int> box = new Box<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                box.Items.Add(numbers);
            }
            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(box, indices[0], indices[1]);

            Console.WriteLine(box.ToString());
        }

        public static void Swap(Box<int> box, int v1, int v2)
        {
            int temp = box.Items[v1];
            box.Items[v1] = box.Items[v2];
            box.Items[v2] = temp;
        }
    }
}
