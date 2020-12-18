using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var minValue = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(minValue.Min());
        }
    }
}
