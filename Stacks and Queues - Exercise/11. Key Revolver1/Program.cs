using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver1
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOFBullet = int.Parse(Console.ReadLine());
            int sizeGunBarel = int.Parse(Console.ReadLine());
            var bulets = Console.ReadLine().Split().Select(int.Parse);
            var locks = Console.ReadLine().Split().Select(int.Parse);
            var valueOfInteligence = int.Parse(Console.ReadLine());
            var buletsStack = new Stack<int>(bulets);
            var locksStack = new Stack<int>(locks.Reverse());
            int counter = 0;
            var bulletSum = buletsStack.Count;
            while (buletsStack.Any())
            {                
                counter++;
                if (counter > sizeGunBarel)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                    continue;
                }
                if (!locksStack.Any())
                {
                    break;
                }
                int currentBulet = buletsStack.Pop();
                int currentLock = locksStack.Pop();
                if (currentBulet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                }                
                else
                {
                    locksStack.Push(currentLock);
                    Console.WriteLine("Ping!");
                }                
            }
            if (!locksStack.Any())
            {
                var earnd = valueOfInteligence - (priceOFBullet * (bulletSum - buletsStack.Count));
                Console.WriteLine($"{buletsStack.Count} bullets left. Earned ${earnd}");
                return;
            }
            Console.WriteLine($"Couldn't get through. Locks left: {locksStack.Count}");
        }
    }
}
