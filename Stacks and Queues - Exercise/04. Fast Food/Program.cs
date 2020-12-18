using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int n = queue.Count;
            var maxOrder = queue.Max();
            for (int i = 0; i < n; i++)
            {
                var currentOrder = queue.Dequeue();
                if (food >= currentOrder)
                {
                    food -= currentOrder;
                }
                else
                {
                    queue.Enqueue(currentOrder);
                }
            }
            Console.WriteLine(maxOrder);
            if (queue.Count > 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", queue));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
