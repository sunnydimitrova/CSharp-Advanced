using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).ToList();
            var nums = new List<int>();
            var oddOEven = Console.ReadLine();
            Predicate<int> predict = oddOEven == "odd" ? new Predicate<int>((n) => n % 2 != 0) : new Predicate<int>((n) => n % 2 == 0);
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predict(i))
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
