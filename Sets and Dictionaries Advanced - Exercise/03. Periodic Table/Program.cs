﻿using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var hashSet = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    hashSet.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", hashSet));
        }
    }
}
