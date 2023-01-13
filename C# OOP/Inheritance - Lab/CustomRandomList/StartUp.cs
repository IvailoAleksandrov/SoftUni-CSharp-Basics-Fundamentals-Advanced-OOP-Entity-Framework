using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           RandomList randomList = new RandomList();
            randomList.Add("abc");
            randomList.Add("xyz");
            randomList.Add("qwerty");

            string randomString = randomList.RandomString();
            string randomString2 = randomList.RandomString();

            Console.WriteLine(randomString);
            Console.WriteLine(randomString);

            Console.WriteLine(randomString);


        }
    }
}
