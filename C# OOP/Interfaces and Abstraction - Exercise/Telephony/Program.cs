using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

         
            foreach (var number in phoneNumber)
            {
                if (number.Length == 10)
                {
                    try
                    {
                        Console.WriteLine(smartphone.Call(number));
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if (number.Length == 7) 
                {
                    try
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    catch (ArgumentException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }


               
            }
            foreach (var website in websites)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(website));
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }


        }
    }
}
