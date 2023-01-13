using System;

namespace _13._Sort_Array_Using_Iterative_way
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# program sort an array
            // in decreasing order using
            // iterative way

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            int temp;
            //traverse 0 to array lenght
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //traverse i+1 to array lenght
                for (int j = i+1; j < arr.Length; j++)
                {
                    // compare array element with all next element
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }




        }
    }
}
