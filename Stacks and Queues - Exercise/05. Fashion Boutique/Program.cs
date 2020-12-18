using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clotes = Console.ReadLine().Split().Select(int.Parse);
            var rackCapasity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(clotes);
            var clotingSum = 0;
            var rackCount = 1;
            while (stack.Any())
            {
                clotingSum += stack.Peek();
                if (clotingSum <= rackCapasity)
                {
                    stack.Pop();
                }
                else
                {
                    rackCount++;
                    clotingSum = 0;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
