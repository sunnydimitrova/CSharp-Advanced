using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var capsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bottleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var caps = new Stack<int>(capsInput.Reverse());
            var bottle = new Stack<int>(bottleInput);
            var wastedLitters = 0;

            while (caps.Any())
            {
                if (!bottle.Any())
                {
                    Console.WriteLine($"Cups: " + string.Join(" ", caps));
                    Console.WriteLine($"Wasted litters of water: {wastedLitters}");
                    return;
                }
                var currentCap = caps.Pop();
                var currentBottle = bottle.Pop();
                if (currentCap <= currentBottle)
                {
                    wastedLitters += currentBottle - currentCap;
                }
                else
                {
                    caps.Push(currentCap - currentBottle);
                }
            }
            Console.WriteLine($"Bottles: " + string.Join(" ", bottle));
            Console.WriteLine($"Wasted litters of water: {wastedLitters}");
        }
    }
}
