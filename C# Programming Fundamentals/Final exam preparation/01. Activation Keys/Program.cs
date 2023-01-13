using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Generate")
            {
                string[] cmd = commands.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];

                if (action == "Contains")
                {
                    string subS = cmd[1];
                    if (activationKey.Contains(subS))
                    {
                        Console.WriteLine($"{activationKey} contains {subS}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string upperOrLower = cmd[1];
                    int startIndex = int.Parse(cmd[2]);
                    int endIndex = int.Parse(cmd[3]);
                    if (upperOrLower == "Upper")
                    {
                        activationKey = activationKey.Substring(0, startIndex) + activationKey.Substring(startIndex, endIndex - startIndex).ToUpper() + activationKey.Substring(endIndex);
                         //    IvailoAleksandrov     3-5 Upper =     
  
                        Console.WriteLine(activationKey);
                    }
                    else
                    {
                        activationKey = activationKey.Substring(0, startIndex) + activationKey.Substring(startIndex, endIndex - startIndex).ToLower() + activationKey.Substring(endIndex);
                        Console.WriteLine(activationKey);
                    }

                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);    
                    Console.WriteLine(activationKey);
                }


                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: { activationKey}");
        }
    }
}
