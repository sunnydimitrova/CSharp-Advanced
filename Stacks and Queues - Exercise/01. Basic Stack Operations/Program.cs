using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            var NSX = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = NSX[0];
            var s = NSX[1];
            var x = NSX[2];
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count <= 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
            }
        }
    }
}
