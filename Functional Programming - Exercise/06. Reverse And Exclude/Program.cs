using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            var divider = int.Parse(Console.ReadLine());
            foreach (var item in numbers.Where(n => n % divider != 0))
            {
                Console.Write(item + " ");
            }
        }
    }
}
