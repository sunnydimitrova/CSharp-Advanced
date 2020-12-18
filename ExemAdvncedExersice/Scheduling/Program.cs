using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var queue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var taskValue = int.Parse(Console.ReadLine());
            var tasks = new Stack<int>(stack);
            var threads = new Queue<int>(queue);
            while (true)
            {
                var curentTask = tasks.Peek();
                var currentThread = threads.Peek();
                if (curentTask == taskValue)
                {
                    break;
                }
                if (currentThread >= curentTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskValue}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
