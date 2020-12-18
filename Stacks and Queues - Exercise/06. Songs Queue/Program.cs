using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Queue<string>(Console.ReadLine().Split(", ").ToArray());
            while (songs.Any())
            {
                var input = Console.ReadLine();
                if (input.Contains("Add"))
                {
                    var arr = input.Split("Add");
                    var song = arr[1].Trim();
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (input.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
     
            }
            Console.WriteLine("No more songs!");
        }
    }
}
