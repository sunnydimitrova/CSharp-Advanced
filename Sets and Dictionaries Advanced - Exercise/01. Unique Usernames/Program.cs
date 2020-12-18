using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                hashSet.Add(input);
            }
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
