using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");

            foreach (var user in userNames)
            {
                if (user.Length>3 && user.Length <=16)
                {
                    bool isUserNameValid = true;

                    foreach (var letter in user) // this is real user name check and if username i false break
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter  == '-' || letter == '_'))
                        {
                            isUserNameValid = false;
                            break;
                        }
                    }
                    if (isUserNameValid)
                    {
                        Console.WriteLine(user);
                    }
                }
            }
        }
    }
}
