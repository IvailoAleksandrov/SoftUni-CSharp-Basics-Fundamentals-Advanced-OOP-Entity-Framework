using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                Song song = new Song(data[0], data[1], data[2]);
                songs.Add(song);
            }
            
            string lastInput = Console.ReadLine();

         
            
            if (lastInput == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == lastInput)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }

    class Song   
    {

        public Song(string typeList, string name, string time)   // Constructor
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;   
        }
        public string TypeList { get; set; }    // Properties
        public string Name { get; set; }    
        public string Time { get; set; }    
    }
}
