using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<char, int>();
            foreach (char letter in input)
            {
                if (!dict.ContainsKey(letter))
                {
                    dict.Add(letter, 0);
                }
                dict[letter]++;
            }
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
