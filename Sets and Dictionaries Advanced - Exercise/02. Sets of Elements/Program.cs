using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var first = numbers[0];
            var second = numbers[1];
            for (int i = 0; i < first; i++)
            {
                var input = int.Parse(Console.ReadLine());
                firstSet.Add(input);
            }
            for (int i = 0; i < second; i++)
            {
                var input = int.Parse(Console.ReadLine());
                secondSet.Add(input);
            }
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
