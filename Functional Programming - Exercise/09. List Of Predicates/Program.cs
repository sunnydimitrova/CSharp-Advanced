using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var allNumbers = new List<int>();
            for (int i = 1; i <= lastNumber; i++)
            {
                if (DivisibleByNumber(dividers, i))
                {
                    allNumbers.Add(i);
                }                
            }
            Console.WriteLine(string.Join(" ", allNumbers));
        }

        static bool DivisibleByNumber(List<int> divaiders, int n)
        {
            var isTrue = true;
            for (int i = 0; i < divaiders.Count; i++)
            {
                if (n % divaiders[i] != 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
    }
}
