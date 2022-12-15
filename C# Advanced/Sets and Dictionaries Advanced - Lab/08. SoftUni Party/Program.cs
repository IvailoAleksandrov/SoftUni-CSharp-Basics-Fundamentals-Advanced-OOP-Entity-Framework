using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guestInput = Console.ReadLine();
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            while (guestInput != "PARTY")
            {
                if (char.IsDigit(guestInput[0]))
                {
                    vip.Add(guestInput);
                }
                else
                {
                    regular.Add(guestInput);
                }
                guestInput = Console.ReadLine();
            }
            string arrivingGuests = Console.ReadLine();

            while (arrivingGuests != "END")
            {
                if (vip.Contains(arrivingGuests))
                {
                    vip.Remove(arrivingGuests);
                }
                else if (regular.Contains(arrivingGuests))
                {
                    regular.Remove(arrivingGuests);
                }
                arrivingGuests = Console.ReadLine();
            }
            Console.WriteLine(vip.Count + regular.Count);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }

        }
    }
}
