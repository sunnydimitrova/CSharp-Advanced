using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var queue = new Queue<int>();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length / 2; i++)
            {
                var current = input[i];
                queue.Enqueue(current);
            }
            for (int i = input.Length / 2; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            bool isTrue = false;
            for (int i = 0; i <= queue.Count; i++)
            {
                var currentQ = queue.Dequeue();
                var nextCurrentQ = queue.Peek();                
                var currentS = stack.Pop();
                var nextS = stack.Peek();
                if (Math.Abs(currentS - currentQ) <= 2)
                {
                    isTrue = true;
                }              
                else
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
