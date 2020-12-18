using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            var greenLight = int.Parse(Console.ReadLine());
            var freeLight = int.Parse(Console.ReadLine());
            var carsPassed = new Stack<string>();
            bool isFreeLight = false;
            var counter = 0;

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (isFreeLight)
                {
                    break;
                }
                if (input != "green")
                {                    
                    for (int i = 0; i < input.Length; i++)
                    {
                        counter++;
                        if (counter == greenLight)
                        {
                            isFreeLight = true;
                        }
                        if (counter > greenLight + freeLight)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{input} was hit at {input[i]}.");
                            return;
                        }
                    }
                    carsPassed.Push(input);
                }
                else
                {
                    counter = 0;
                }
            }           
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed.Count} total cars passed the crossroads.");                        
        }
    }
}
