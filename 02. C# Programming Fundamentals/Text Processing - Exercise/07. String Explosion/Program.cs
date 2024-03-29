﻿using System;

namespace T07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string textField = Console.ReadLine();
            int bomb = 0;
           
            for (int i = 0; i < textField.Length; i++)
            {
                // Step 4 checking if bomb with biger damage than 0 in the textField and is different from >
                if (bomb > 0 && textField[i] != '>')
                {
                    textField = textField.Remove(i, 1);
                    bomb--;
                    i--;
                }
                
                //Step 4.1 if the index the current char == > than we have an explosion and then we add the power of that exlosion that we have 
                else if (textField[i] == '>')
                {
                    bomb += int.Parse(textField[i + 1].ToString());
                }
            }
            Console.WriteLine(textField);
        }
    }
}