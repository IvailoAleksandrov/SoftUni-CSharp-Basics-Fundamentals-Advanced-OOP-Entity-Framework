using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalSum = 0;


            // ((daysInMonth * capsulesCount) * pricePerCapsule)
            //	"The price for the coffee is: ${price}"
            //    "Total: ${totalPrice}"

            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double orderSum = pricePerCapsule * days * capsules;
                Console.WriteLine($"The price for the coffee is: ${orderSum:F2}");
                totalSum += orderSum;  
            }

            Console.WriteLine($"Total: ${totalSum:f2}");


        }
    }
}
