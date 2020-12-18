using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.ReadLine().Split().Where(name => name.Length <= n)
                .ToList().ForEach(Console.WriteLine);
        }
    }
}
