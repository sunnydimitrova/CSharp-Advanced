using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;
            Func<int[], int[]> multiply = ((arr) => arr.Select(n => n * 2).ToArray());
            Func<int[], int[]> subtract = ((arr) => arr.Select(n => n - 1).ToArray());
            Func<int[], int[]> add = ((arr) => arr.Select(n => n + 1).ToArray());
            Action<int[]> print =((arr) => Console.WriteLine(string.Join(" ", arr)));
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "multiply")
                {
                    multiply(numbers);
                }
                else if (input == "subtract")
                {
                    subtract(numbers);
                }
                else if (input == "add")
                {
                    add(numbers);
                }
                else if (input == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
