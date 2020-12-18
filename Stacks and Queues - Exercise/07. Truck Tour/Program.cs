using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pumps = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                var currentInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var fuel = currentInfo[0];
                var distance = currentInfo[1];
                pumps.Enqueue(currentInfo);              
            }
            var counter = 0;
            while (true)
            {
                var sumOfFuel = 0;
                var foundPoint = true;
                for (int i = 0; i < n; i++)
                {
                    var currentPump = pumps.Dequeue();
                    sumOfFuel += currentPump[0];
                    if (sumOfFuel < currentPump[1])
                    {
                        foundPoint = false;
                    }
                    sumOfFuel -= currentPump[1];
                    pumps.Enqueue(currentPump);
                }
                if (foundPoint)
                {
                    break;
                }
                counter++;
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(counter);
        }
    }
}
