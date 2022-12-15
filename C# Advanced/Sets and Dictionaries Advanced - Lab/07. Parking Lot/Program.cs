using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string inOut = info[0];
                string plateNumber = info[1];

                if (inOut == "IN")
                {
                    if (!set.Contains(plateNumber))
                    {
                        set.Add(plateNumber);
                    }
                }
                else if (inOut =="OUT")
                {
                    if (set.Contains(plateNumber))
                    {
                        set.Remove(plateNumber);
                    }
                }
                
                input = Console.ReadLine();
            }
            if (set.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, set));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
